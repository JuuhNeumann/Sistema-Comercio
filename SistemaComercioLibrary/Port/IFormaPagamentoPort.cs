using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IFormaPagamentoPort
    {
        void AddFormaPagamento(FormaPagamento formaPagamento);
        FormaPagamento GetFormaPagamento();
    }
}
