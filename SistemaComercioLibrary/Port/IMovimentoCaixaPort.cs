using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Port
{
    public interface IMovimentoCaixaPort
    {
        void AddMovimentoCaixa(MovimentoCaixa movimentoCaixa);
        void ReadMovimentoCaixa(List<MovimentoCaixa> movimentoCaixa);
        MovimentoCaixa GetMovimentoCaixa();
    }
}

