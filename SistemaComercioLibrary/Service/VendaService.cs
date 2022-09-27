using SistemaComercioBiblioteca.Classes;
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
    public class VendaService : IVendaPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Venda.Count();
        }

        public void AddVenda(Venda venda)
        {
            _db.Venda.Add(venda);
            _db.SaveChanges();
        }

        public void ConsultVenda(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DelVenda(string id)
        {
            throw new NotImplementedException();
        }

        public Compra GetCompra()
        {
            throw new NotImplementedException();
        }

        public void IssueReportVenda(List<Venda> situacaoVenda)
        {
            throw new NotImplementedException();
        }

        public void ReadVenda(List<Venda> venda)
        {
            throw new NotImplementedException();
        }

        public void UpdateVenda(string id)
        {
            throw new NotImplementedException();
        }
       
    }
}
