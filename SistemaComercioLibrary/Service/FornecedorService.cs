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
    public class FornecedorService : IFornecedorPort
    {
        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Fornecedor.Count();
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            _db.Fornecedor.Add(fornecedor);
            _db.SaveChanges();
        }

        public void DelFornecedor(string id)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> GetAllFornecedor()
        {
            return  _db.Fornecedor.ToList();
        }

        public void ReadFornecedor(List<Fornecedor> fornecedor)
        {
            throw new NotImplementedException();
        }

        public void UpdateFornecedor(string id)
        {
            throw new NotImplementedException();
        }
    }
}
