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
    public class ContaPagarService : IContaPagarPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddContaPagar(ContaPagar contaPagar)
        {
            _db.ContaPagar.Add(contaPagar);
            _db.SaveChanges();
        }

        public void AddContaPagarCompra(Compra compra)
        {
            throw new NotImplementedException();
        }

        public Caixa GetContaPagar()
        {
            throw new NotImplementedException();
        }

        public void IssueReportContaPagar(ContaPagar dataPagamento)
        {
            throw new NotImplementedException();
        }
    }
}
