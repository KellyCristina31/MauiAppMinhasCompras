
using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
       
           

        string _descricao;
        string _categoria;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }
        }
                   
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double Total { get => Quantidade * Preco; }

        // NOVO CAMPO
        public string Categoria
        {
            get => _categoria;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _categoria = value;
            }
        }
        public List<string> Categorias { get; } = new()
{
    "Alimentos",
    "Higiene",
    "Limpeza",
    "Outros"
};


    } // Fecha classe
} // Fecha Namespace    }

   
