namespace P1;

using System;
using System.Windows;
using P1.Primitives;
using P1.Views;

public partial class MainWindow : Primitives.Window
{
    public Component CurrentView { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        CurrentView = new ViewA();
        CurrentView.Loaded += (s, ea) =>
        {
            Rect workArea = SystemParameters.WorkArea;
            Height = workArea.Height * 0.95;
            Width = Math.Min(workArea.Width * 0.95, 1400);
            Left = (workArea.Width - Width) / 2 + workArea.Left;
            Top = (workArea.Height - Height) / 2 + workArea.Top;
        };
    }
}