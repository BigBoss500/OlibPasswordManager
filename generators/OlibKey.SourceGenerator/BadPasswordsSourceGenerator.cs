﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace OlibKey.SourceGenerator;

/// <summary>
/// 
/// </summary>
[Generator]
public class BadPasswordsSourceGenerator : ISourceGenerator
{
	public void Execute(GeneratorExecutionContext context)
	{
		const string nameSpace = "OlibKey.Core.StaticMembers";
		const string badPasswordsField = "BadPasswords";
		const string textInformationClass = "TextInformation";

		AdditionalText? additionalText =
			context.AdditionalFiles.FirstOrDefault(file => Path.GetFileName(file.Path).Contains("BadPasswords.txt"));

		SourceText? sourceText = additionalText?.GetText();

		if (sourceText is null)
			throw new NullReferenceException(
				$"BadPasswords is null, check the location to the file with bad passwords\nAll paths:\n{string.Join("\n", context.AdditionalFiles.Select(x => x.Path))}");

		StringBuilder stringBuilder = new();

		stringBuilder.AppendLine("// <auto-generated/>");
		stringBuilder.AppendLine($"namespace {nameSpace};");
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine($"public static partial class {textInformationClass}");
		stringBuilder.AppendLine("{");
		stringBuilder.AppendLine($"\tpublic static readonly string[] {badPasswordsField} =");
		stringBuilder.AppendLine("\t{");

		foreach (TextLine textLine in sourceText.Lines)
		{
			stringBuilder.AppendLine($"\t\t\"{textLine.ToString()}\",");
		}

		stringBuilder.AppendLine("\t};");
		stringBuilder.AppendLine("}");

		context.AddSource($"{textInformationClass}.g.cs", stringBuilder.ToString());
	}

	public void Initialize(GeneratorInitializationContext context)
	{
		// No initialization required for this one
	}
}