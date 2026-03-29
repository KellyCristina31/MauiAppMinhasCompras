using System.Collections.ObjectModel;

namespace MauiAppMinhasCompras.Views;


    public class RelatorioCategoriasViewModel : BaseViewModel
    {
        public ObservableCollection<RelatorioCategoria> Relatorio { get; set; }

    public RelatorioCategoriasViewModel() => CarregarRelatorio();

    private async void CarregarRelatorio()
        {
            var produtos = await App.Database.GetProdutosAsync();

            var dados = produtos
                .GroupBy(p => p.Categoria)
                .Select(g => new RelatorioCategoria
                {
                    Categoria = g.Key,
                    Total = g.Sum(p => p.Preco * p.Quantidade)
                });

            Relatorio = new ObservableCollection<RelatorioCategoria>(dados);
        }
    }

    public class RelatorioCategoria
    {
        public string Categoria { get; set; }
        public double Total { get; set; }
    }
}