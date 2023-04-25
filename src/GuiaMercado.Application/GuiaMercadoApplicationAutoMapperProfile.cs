using AutoMapper;
using GuiaMercado.Produtos;

namespace GuiaMercado;

public class GuiaMercadoApplicationAutoMapperProfile : Profile
{
    public GuiaMercadoApplicationAutoMapperProfile()
    {
        CreateMap<Produto, ProdutoDto>();
    }
}
