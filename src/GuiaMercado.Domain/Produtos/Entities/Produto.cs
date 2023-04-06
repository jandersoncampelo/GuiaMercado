using GuiaMercado.Categorias;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace GuiaMercado.Produtos
{
    public class Produto : FullAuditedAggregateRoot<long>
    {
        public string Descricao { get; set; }
        public decimal UltimoPreco { get; set; }
        public DateTime UltimaCompra { get; set; }
        public long CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
