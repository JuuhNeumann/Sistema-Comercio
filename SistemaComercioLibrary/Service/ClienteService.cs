﻿using SistemaComercioLibrary.Classes;
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

        public void ReadCliente(List<Cliente> ciente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAllCliente()
        {
            return _db.Cliente.ToList();
        }

        public Cliente GetByNomeCliente(string nome)
        {
            return _db.Cliente.OrderByDescending(x => x.Nome.Equals(nome)).FirstOrDefault(); //pega o primeiro nome
        }

        public Cliente GetByIdCliente(int id)
        {
            return _db.Cliente.FirstOrDefault(x => x.Id.Equals(id)); //pega o id
        }

        public void UpdateCliente(Cliente cliente)
        {
            var cli = _db.Cliente.FirstOrDefault(x => x.Id == cliente.Id); //pega o id
            _db.SaveChanges();
        }
    }
}
