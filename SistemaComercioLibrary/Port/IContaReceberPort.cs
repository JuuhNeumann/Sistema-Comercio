using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IContaReceberPort
    {
        void AddContaReceber(ContaReceber contaReceber);
        //gera uma conta a partir de uma venda
        void AddContaReceberVenda(Venda venda);
        //emitir relatorio de contas a receber com opção: a receber, a vencer, em atraso e pagas.
        void IssueReportContaReceber(ContaReceber dataRecebimento);
        Caixa GetContaReceber();
        //metodo para baixa uma conta a receber????
        //gerar boleto??????
    }
}
