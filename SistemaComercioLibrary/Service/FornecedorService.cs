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
    public class IFornecedor : IFornecedorPort
    {
        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Compra.Count();
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            _db.Compra.Add(fornecedor);
            _db.SaveChanges();
        }

        public void DelFornecedor(string id)
        {
            throw new NotImplementedException();
        }

        public Fornecedor GetFornecedor()
        {
            throw new NotImplementedException();
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
