using P1.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace P1.Views;

public record Feature(string Title, string Description);

public partial class ViewA : Component
{
    public List<Feature> Features { get; } = new()
    {
        new Feature("Image Optimization", "<Image> and automatic Image Optimization with instant builds."),
        new Feature("Internationalization", "Built-in Domain & Subdomain Routing and Automatic Language detection."),
        new Feature("Next.js Analytics", "A true lighthouse score based on real visitor data & page-by-page insights."),
        new Feature("Zero Config", "Automatic compilation and bundling. Optimized for production from the start."),
        new Feature("Hybrid: SSG and SSR", "Pre-render pages at build time (SSG) or request time (SSR) in a single project."),
        new Feature("Middleware", "Dynamic routing defined by code instead of configuration."),
        new Feature("TypeScript Support", "Automatic TypeScript configuration and compilation."),
        new Feature("Fast Refresh", "Fast, reliable live-editing experience, as proven at Facebook scale."),
        new Feature("File-system Routing", "Every component in the `pages` directory becomes a route."),
        new Feature("API Routes", "Optionally create API endpoints to provide backend functionality."),
        new Feature("Built-in CSS Support", "Create component-level styles with CSS modules. Built-in Sass support."),
        new Feature("Code-splitting and Bundling", "Optimized bundle splitting algorithm created by the Google Chrome team."),
    };

    public List<string> TopLogos { get; } = Enumerable.Repeat(
        new List<string>()
        {
            "/Assets/Logos/opencollective.svg",
            "/Assets/Logos/eaze.svg",
            "/Assets/Logos/magicleap.svg",
            "/Assets/Logos/trulia.svg",
            "/Assets/Logos/netflix.svg",
            "/Assets/Logos/github.svg",
            "/Assets/Logos/scale.svg",
            "/Assets/Logos/ticketmaster.svg",
            "/Assets/Logos/twitch.svg",
            "/Assets/Logos/sesame.svg",
            "/Assets/Logos/pling.svg"
        },
        2
    )
    .SelectMany(i => i)
    .ToList();

    public List<string> BottomLogos { get; } = Enumerable.Repeat(
        new List<string>()
        {
            "/Assets/Logos/authzero.svg",
            "/Assets/Logos/tencent.svg",
            //"/Assets/Logos/jet.svg",
            "/Assets/Logos/starbucks.svg",
            "/Assets/Logos/docker.svg",
            "/Assets/Logos/hulu.svg",
            "/Assets/Logos/coinbase.svg",
            "/Assets/Logos/uber.svg",
            "/Assets/Logos/invision.svg",
            "/Assets/Logos/trovit.svg",
            "/Assets/Logos/binance.svg"
        },
        2
    )
    .SelectMany(i => i)
    .ToList();

    public ViewA()
    {
        InitializeComponent();
    }
}