using Volo.Abp.Domain.Entities.Auditing;

namespace GuiaMercado.Categorias
{
    public class Categoria : AuditedAggregateRoot<long>
    {
        public string Descricao { get; set; }
    }
}
