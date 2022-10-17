using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IProdutoPort
    {
        int Count();
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        void DelProduto(string id);
        //mostra uma LISTA de fornecedores
        void ReadProduto(List<Produto> produto);
        List<Produto> GetAllProduto();
        Produto GetByIdProduto(int id);
    }
}
