using SistemaComercioLibrary.Classes;
using System.Collections.Generic;

namespace SistemaComercioLibrary.Port
{
    public interface IFornecedorPort
    {
        void AddFornecedor(Fornecedor fornecedor);
        void UpdateFornecedor(string id);
        void DelFornecedor(string id);
        //mostra uma LISTA de fornecedores
        void ReadFornecedor(List<Fornecedor> fornecedor);
        Fornecedor GetFornecedor();
    }
}
