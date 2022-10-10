using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IClientePort
    {
        int Count();
        void AddCliente(Cliente cliente);
        void UpdateCliente(string id);
        void DelCliente(string id);
        //mostra uma LISTA de fornecedores
        void ReadCliente(List<Cliente> ciente);
        List<Cliente> GetAllCliente();
    }
}
