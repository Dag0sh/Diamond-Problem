using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Controls;  // Добавьте это, если отсутствует
using AvaloniaExample;

namespace Animals;


public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();  // Проверьте, чтобы MainWindow был правильно указан
        }

        base.OnFrameworkInitializationCompleted();
    }
}