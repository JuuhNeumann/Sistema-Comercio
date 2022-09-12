using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IVendaPort
    {
        void AddVenda(Venda venda);
        void DelVenda(string id);
        void UpdateVenda(string id);
        void ReadVenda(List<Venda> venda);
        //consulta por cliente (e periodo???)
        void ConsultVenda(Cliente cliente);
        //emitir relatorio de vendas realizadas filtrar por periodo?????? e cliente
        void IssueReportVenda(List<Venda> situacaoVenda);
        Compra GetCompra();
    }
}
