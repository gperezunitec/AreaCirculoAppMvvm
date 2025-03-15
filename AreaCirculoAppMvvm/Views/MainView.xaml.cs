using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCirculoAppMvvm.ViewModels;

namespace AreaCirculoAppMvvm.Views;

public partial class MainView : ContentPage
{
    
    
    private MainViewModels viewModel;
    
    public MainView()
    {
        InitializeComponent();
        viewModel = new MainViewModels();
        BindingContext = viewModel;
    }
}