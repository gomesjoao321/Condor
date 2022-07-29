using CondorBicicletas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CondorBicicletas.Repositories
{
    public interface IProdutoRepository
    {
        Task SaveProdutos(List<Livro> livros);
        Task<IList<Produto>> GetProdutos();
    }
}