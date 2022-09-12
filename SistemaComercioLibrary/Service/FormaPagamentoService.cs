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
    public class FormaPagamentoService : IFormaPagamentoPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddFormaPagamento(FormaPagamento formaPagamento)
        {
            _db.Add(formaPagamento);
            _db.SaveChanges();
        }

        public FormaPagamento GetFormaPagamento()
        {
            throw new NotImplementedException();
        }
    }
}
