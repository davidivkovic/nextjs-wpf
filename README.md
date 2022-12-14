# Next.js Homepage Clone
This project demonstrates the capabilities of WPF showcasing a simple yet beautiful application.

## Built using đģđ
- [.NET 6](https://dotnet.microsoft.com/en-us/)
- [WPF](https://github.com/dotnet/wpf)
- [CommunityToolkit.Mvvm](https://github.com/CommunityToolkit/dotnet)
- [PropertyChanged.Fody](https://github.com/Fody/PropertyChanged/)
- [Kasay.DependencyProperty.WPF.Fody](https://github.com/robinzevallos/Kasay.DependencyProperty.WPF.Fody)
- [SharpVectors.Wpf](https://github.com/ElinamLLC/SharpVectors)
- [Inter Font](https://rsms.me/inter/)

# Showcase đ¸
![cta](/images/cta.png)
![features](/images/features.png)
![hero](/images/hero.png)
![learn](/images/learn.png)
![subscribe](/images/subscribe.png)

https://user-images.githubusercontent.com/16724395/192407115-065e5588-88dd-4b21-a22d-f9ab15f5fa92.mp4

### Info âšī¸
The goal of this project was to develop a simple binding system in WPF, inspired by declarative frontend frameworks such as Vue.js.

Implemented are:
- [`Window`](/src/Primitives/Window.cs) - A window whose title and icon are stripped using the win32 api `uxtheme.dll`, providing a clean look.
- [`Component`](/src/Primitives/Component.cs) - A Simple component abstraction, provding binding capabilities which are generated using `PropertyChanged.Fody`.
- [`Sample View`](/src/Views/ViewA.xaml.cs) - The main view of the application. It inherits the aforementioned `Component`.
- [`Main Window`](/src/MainWindow.xaml.cs) - Views can be dynamically swapped using the `CurrentView` property of type `Component`.
- [`Logo Track`](/src/Components/LogoTrack.xaml) - Demonstrates how to encapsulate a specific component. It also exposes "props" (Dependency Properties) using the `[Bind]` attribute found in `Kasay.DependencyProperty.WPF.Fody`.

## Getting Started đ ī¸
1. Clone the project using git or by downloading the source code
2. Open the solution file using Visual Studio 2022 or the latest version of Jetbrains Rider
3. Restore NuGet Packages, Build and Run the application

### Remarks âī¸
This application was built and tested using Windows 11. It is not guaranteed to work on older versions of Windows.

## Legal âī¸
I am not affiliated, associated, authorized, endorsed by, or in any way officially connected to vercel.com.

All product and company names are trademarksâĸ or registeredÂŽ trademarks of their respective holders. Use of them does not imply any affiliation with or endorsement by them.
