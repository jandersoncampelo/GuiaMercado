using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace GuiaMercado.Produtos
{
    public interface IProdutoAppService : IApplicationService
    {
        Task<PagedResultDto<ProdutoDto>> GetListAsync(PagedAndSortedResultRequestDto input);
    }
}
