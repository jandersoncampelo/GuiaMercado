using GuiaMercado.Produtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace GuiaMercado.Categorias
{
    public class CategoriaAppService : GuiaMercadoAppService, ICategoriaAppService
    {
        private readonly IRepository<Categoria, long> _categoriaRepository;

        public CategoriaAppService(IRepository<Categoria, long> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<PagedResultDto<CategoriaDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var categorias = await _categoriaRepository
                .GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);
            
            var count = await _categoriaRepository.GetCountAsync();

            return new PagedResultDto<CategoriaDto>(
                count,
                ObjectMapper.Map<List<Categoria>, List<CategoriaDto>>(categorias)
            );
        }
    }
}
