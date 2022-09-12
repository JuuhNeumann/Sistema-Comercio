using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IContaPagarPort
    {
        void AddContaPagar(ContaPagar contaPagar);
        //gera uma conta a partir de uma compra
        void AddContaPagarCompra(Compra compra);
        //emitir relatorio de contas a pagar com opção: nao vencidas, a vencer, em atraso e paga
        void IssueReportContaPagar(ContaPagar dataPagamento);
        Caixa GetContaPagar();
    }
}
