﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.Flexbox.Demo
{
    public sealed class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent() => AvaloniaXamlLoader.Load(this);
    }
}
