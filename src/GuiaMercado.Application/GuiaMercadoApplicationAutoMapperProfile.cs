using AutoMapper;
using GuiaMercado.Categorias;
using GuiaMercado.Produtos;

namespace GuiaMercado;

public class GuiaMercadoApplicationAutoMapperProfile : Profile
{
    public GuiaMercadoApplicationAutoMapperProfile()
    {
        CreateMap<Produto, ProdutoDto>();
        CreateMap<Categoria, CategoriaDto>();
    }
}
