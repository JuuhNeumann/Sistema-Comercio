using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface ICompraPort
    {
        int Count();
        void AddCompra(Compra compra);
        void DelCompra(Compra compra);
        void UpdateCompra(Compra compra);
        List<Compra> GetAllCompra();
        //consulta por fornecedor (e periodo???)
        void ConsultCompra(Fornecedor fornecedor);
        //emitir relatorio de compras lançadas
        void IssueReportCompra(List<Compra> situacaoCompra);
        Compra GetCompra();
        Compra GetByIdCompra(int id);
    }
}
