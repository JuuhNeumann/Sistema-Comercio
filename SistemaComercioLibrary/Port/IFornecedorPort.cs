using SistemaComercioLibrary.Classes;
using System.Collections.Generic;

namespace SistemaComercioLibrary.Port
{
    public interface IFornecedorPort
    {
        int Count();
        void AddFornecedor(Fornecedor fornecedor);
        void UpdateFornecedor(Fornecedor fornecedor);
        void DelFornecedor(Fornecedor fornecedor);
        //mostra uma LISTA de fornecedores
        void ReadFornecedor(List<Fornecedor> fornecedor);
        Fornecedor GetByNomeFornecedor(string nome);
        Fornecedor GetByIdFornecedor(int id);
        List<Fornecedor> GetAllFornecedor();
    }
}
