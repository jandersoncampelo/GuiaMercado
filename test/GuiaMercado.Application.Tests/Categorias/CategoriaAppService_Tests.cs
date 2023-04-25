using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace GuiaMercado.Categorias
{
    public class CategoriaAppService_Tests : GuiaMercadoApplicationTestBase
    {
        private readonly ICategoriaAppService _categoriaAppservice;

        public CategoriaAppService_Tests()
        {
            _categoriaAppservice = GetRequiredService<ICategoriaAppService>();
        }

        [Fact]
        public async Task Should_Get_Categoria_List()
        {
            //Arrange

            //Act
            var output = await _categoriaAppservice.GetListAsync(
                new PagedAndSortedResultRequestDto());

            //Assert
            output.TotalCount.ShouldBe(4);
            output.Items.ShouldContain(x => x.Descricao == "Hortifruti");
        }
    }
}
