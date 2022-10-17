using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercioLibrary.Service
{
    public class ProdutoService : IProdutoPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Produto.Count();
        }
        public void AddProduto(Produto produto)
        {
            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public void DelProduto(string id)
        {
            throw new NotImplementedException();
        }

        public void ReadProduto(List<Produto> produto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduto(Produto produto)
        {
            var prod = _db.Produto.FirstOrDefault(x => x.Id == produto.Id); //pega o id
            prod.Nome = produto.Nome;
            _db.SaveChanges();
        }

        public List<Produto> GetAllProduto()
        {
            return _db.Produto.ToList();
        }

        public Produto GetByIdProduto(int id)
        {
            var produto = _db.Produto.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
            var fornecedor = _db.Fornecedor.FirstOrDefault(x => x.Id.Equals(produto.Id_Fornecedor)); //pega o id
            produto.Fornecedor = fornecedor;

            return produto;
        }
    }
}
