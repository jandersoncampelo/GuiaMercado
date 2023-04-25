using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace GuiaMercado.Categorias
{
    public interface ICategoriaAppService : IApplicationService
    {
        Task<PagedResultDto<CategoriaDto>> GetListAsync(PagedAndSortedResultRequestDto input);
    }
}
