using SistemaComercioLibrary.Classes;

namespace SistemaComercioLibrary.Port
{
    public interface IFornecedorPort
    {
        void AddFornecedor(Fornecedor fornecedor);
        Fornecedor GetFornecedor();
    }
}
