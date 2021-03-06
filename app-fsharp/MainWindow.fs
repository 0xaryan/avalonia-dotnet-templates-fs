﻿namespace AvaloniaAppTemplate

open Avalonia
open Avalonia.Markup.Xaml
open Avalonia.Controls

type MainWindow() as this =
    inherit Window()

    do
        AvaloniaXamlLoader.Load this
#if DEBUG
        this.AttachDevTools();
#endif