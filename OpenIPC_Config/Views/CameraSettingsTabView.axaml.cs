using System.ComponentModel;
using Avalonia.Controls;
using OpenIPC_Config.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace OpenIPC_Config.Views;

public partial class CameraSettingsTabView : UserControl, INotifyPropertyChanged
{
    public CameraSettingsTabView()
    {
        InitializeComponent();
        
        if (!Design.IsDesignMode)
        {
            DataContext = App.ServiceProvider.GetService<CameraSettingsTabViewModel>();
        }
    }
}