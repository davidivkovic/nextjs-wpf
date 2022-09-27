namespace P1.Components;

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.Primitives;
using Kasay;
using P1.Primitives;

public partial class LogoTrack : Component
{
    [Bind] public Duration Duration { get; set; }
    [Bind] public List<string> Logos { get; set; }
    public double StartingOffset => -200;
    public double FinishingOffset { get; set; }

    public LogoTrack()
    {
        InitializeComponent();
        Track.SizeChanged += (_, e) =>
        {
            FinishingOffset = -e.NewSize.Width / 2 + StartingOffset;
        };
    }
}
