using Volo.Abp.Application.Dtos;

namespace GuiaMercado.Categorias
{
    public class CategoriaDto : AuditedEntityDto<long>
    {
        public string Descricao { get; set; }
    }
}
