using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace GuiaMercado.Produtos
{
    public class ProdutoAppService : GuiaMercadoAppService, IProdutoAppService
    {
        private readonly IRepository<Produto, long> _produtoRepository;

        public ProdutoAppService(IRepository<Produto, long> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<PagedResultDto<ProdutoDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var query = await _produtoRepository.WithDetailsAsync(x => x.Categoria);

            query = query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .OrderBy(input.Sorting ?? nameof(Produto.Descricao))
                .AsQueryable();

            var products = await AsyncExecuter.ToListAsync(query);
            var count = await _produtoRepository.GetCountAsync();

            return new PagedResultDto<ProdutoDto>(
                count,
                ObjectMapper.Map<List<Produto>, List<ProdutoDto>>(products)
            );
        }
    }
}
