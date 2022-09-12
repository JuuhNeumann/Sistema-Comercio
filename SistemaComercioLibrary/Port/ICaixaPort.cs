using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface ICaixaPort
    {
        void AddCaixa(Caixa caixa);
        //atualiza saldo em função da venda
        void UpdateCaixaVenda(Venda venda);
        //atualiza saldo em função do recebimento
        void UpdateCaixaRecebimento(ContaReceber contaReceber);
        //atualiza saldo em função do pagamento
        void UpdateCaixaPagamento(ContaPagar contaPagar);
        Caixa GetCaixa();
    }
}
