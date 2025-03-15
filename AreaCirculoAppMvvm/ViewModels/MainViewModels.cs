using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels;

public partial class MainViewModels:ObservableObject
{
    
    
    private void Alerta(string Titulo, string Mensaje)
    {
        MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
    }

    
    
    
    [ObservableProperty]
    private double radio;
    
    
    [ObservableProperty]
    private double area;
    

    [RelayCommand]
    private void Calcular()
    {
        if (radio == 0)
        {
            Alerta("Error", "Ingrese el radio");
        }
        else
        {
            Area = Math.PI * Math.Pow(Radio, 2); 
        }
        
    }
    
    [RelayCommand]
    private void Limpiar()
    {
        Radio = 0;
        Area = 0;
    }

    
}