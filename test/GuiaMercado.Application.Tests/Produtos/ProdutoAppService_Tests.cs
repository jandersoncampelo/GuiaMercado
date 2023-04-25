using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace GuiaMercado.Produtos
{
    public class ProdutoAppService_Tests : GuiaMercadoApplicationTestBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoAppService_Tests()
        {
            _produtoAppService = GetRequiredService<IProdutoAppService>();
        }

        [Fact]
        public async Task Should_Get_Produto_List()
        {
            //Arrange

            //Act
            var output = await _produtoAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            output.TotalCount.ShouldBe(4);
            output.Items.ShouldContain(x => x.Descricao == "Produto1");
        }
    }
}
