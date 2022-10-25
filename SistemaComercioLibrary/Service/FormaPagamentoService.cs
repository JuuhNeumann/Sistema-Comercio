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

        private readonly DataBaseContext _db = new DataBaseContext(); //_db indica injeção de dependência

        public void AddFormaPagamento(FormaPagamento formaPagamento)
        {
            _db.FormaPagamento.Add(formaPagamento);
            _db.SaveChanges();
        }

        public FormaPagamento GetFormaPagamento()
        {
            throw new NotImplementedException();
        }
    }
}
