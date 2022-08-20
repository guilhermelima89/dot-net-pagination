using Api.Models;
using Api.Pagination;

namespace Api.Interfaces;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<PagedList<Produto>> GetWithEFCore(QueryStringParameters request);
    Task<PagedResult<Produto>> GetWithDapper(QueryStringParameters request);
}
