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
    public class ContaReceberService : IContaReceberPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddContaReceber(ContaReceber contaReceber)
        {
            _db.ContaReceber.Add(contaReceber);
            _db.SaveChanges();
        }

        public void AddContaReceberVenda(Venda venda)
        {
            throw new NotImplementedException();
        }

        public Caixa GetContaReceber()
        {
            throw new NotImplementedException();
        }

        public void IssueReportContaReceber(ContaReceber dataRecebimento)
        {
            throw new NotImplementedException();
        }
    }
}
