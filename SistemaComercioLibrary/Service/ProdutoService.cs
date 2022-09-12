using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class ProdutoService : IProdutoPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddProduto(Produto produto)
        {
            _db.Add(produto);
            _db.SaveChanges();
        }

        public void DelProduto(string id)
        {
            throw new NotImplementedException();
        }

        public Produto GetProduto()
        {
            throw new NotImplementedException();
        }

        public void ReadProduto(List<Produto> produto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduto(string id)
        {
            throw new NotImplementedException();
        }
    }
}
