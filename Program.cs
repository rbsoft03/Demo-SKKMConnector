using System;
using Avalonia;

namespace SkkmNugetSample;

internal static class Program
{
    // Точка входа. Avalonia сама выбирает бэкенд под ОС (Windows/Linux/macOS).
    [STAThread]
    public static void Main(string[] args)
        => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
}
