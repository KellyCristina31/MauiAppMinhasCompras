using MauiAppMinhasCompras.ViewModels;

namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
    public ListaProduto()
    {
        InitializeComponent();
        BindingContext = new ListaProdutosViewModel();
    }
}