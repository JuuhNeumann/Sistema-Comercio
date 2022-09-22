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
    public class ClienteService : IClientePort
    {

        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Cliente.Count();
        }

        public void AddCliente(Cliente cliente)
        {
            _db.Cliente.Add(cliente);
            _db.SaveChanges();
        }

        public void DelCliente(string id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetCliente()
        {
            throw new NotImplementedException();
        }

        public void ReadCliente(List<Cliente> ciente)
        {
            throw new NotImplementedException();
        }

        public void UpdateCliente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
