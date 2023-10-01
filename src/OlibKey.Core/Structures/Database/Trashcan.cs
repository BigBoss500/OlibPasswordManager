﻿using Avalonia.Collections;
using PleasantUI;

namespace OlibKey.Core.Structures;

public class Trashcan : ViewModelBase
{
    private AvaloniaList<Data> _data = new();

    public AvaloniaList<Data> Data
    {
        get => _data;
        set => RaiseAndSet(ref _data, value);
    }
}