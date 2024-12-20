using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Dock.ViewModels;
using Dock.Models;
using Dock.Views;

namespace Dock;

public partial class App : Application
{
    
    private static Data D = new Data();
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            BindingPlugins.DataValidators.RemoveAt(0);
            
            desktop.MainWindow = new MainWindow
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                DataContext = new MainWindowViewModel(),
            };
                
        }

        base.OnFrameworkInitializationCompleted();
    }
}