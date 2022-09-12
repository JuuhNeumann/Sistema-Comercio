using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class AdmService : IAdmPort
    {

       private DataBaseContext _db = new DataBaseContext();

        public void AddAdm(Adm adm)
        {
            _db.Add(adm);
            _db.SaveChanges();
        }

        public Adm GetAdm()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            var usuario = _db.Adm.FirstOrDefault(x => x.Usuario.Equals(username) );
            var senha = _db.Adm.FirstOrDefault(x => x.Senha.Equals(password));

            if(usuario != null & senha != null)
                return true;

            return false;
        }
    }
}
