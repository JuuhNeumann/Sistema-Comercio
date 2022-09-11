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

        public void AddFornecedor(Fornecedor fornecedor)
        {
            _db.Fornecedor.Add(fornecedor);
            _db.SaveChanges();
        }

        public Fornecedor GetFornecedor()
        {
            throw new NotImplementedException();
        }

    }
}
