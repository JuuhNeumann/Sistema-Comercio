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
    public class MovimentoCaixaService : IMovimentoCaixaPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public void AddMovimentoCaixa(MovimentoCaixa movimentoCaixa)
        {
            _db.MovimentoCaixa.Add(movimentoCaixa);
            _db.SaveChanges();
        }

        public MovimentoCaixa GetMovimentoCaixa()
        {
            throw new NotImplementedException();
        }

        public void ReadMovimentoCaixa(List<MovimentoCaixa> movimentoCaixa)
        {
            throw new NotImplementedException();
        }
    }
}
