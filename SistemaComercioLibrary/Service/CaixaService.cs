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
    public class CaixaService : ICaixaPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddCaixa(Caixa caixa)
        {
            _db.Caixa.Add(caixa);
            _db.SaveChanges();
        }

        public Caixa GetCaixa()
        {
            throw new NotImplementedException();
        }

        public void UpdateCaixaPagamento(ContaPagar contaPagar)
        {
            throw new NotImplementedException();
        }

        public void UpdateCaixaRecebimento(ContaReceber contaReceber)
        {
            throw new NotImplementedException();
        }

        public void UpdateCaixaVenda(Venda venda)
        {
            throw new NotImplementedException();
        }
    }
}
