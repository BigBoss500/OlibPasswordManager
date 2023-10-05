﻿using Avalonia.Controls;
using OlibKey.Core.Structures;

namespace OlibKey.Core.Views.MainWindowPages;

public partial class CreateAndDecryptDatabasePage : UserControl
{
    public CreateAndDecryptDatabasePage()
    {
        InitializeComponent();

        Random random = new();
        TextBlockTip.Text = OlibKeyApp.GetLocalString(TextInformation.Tips[random.Next(0, TextInformation.Tips.Length)]);
    }
}