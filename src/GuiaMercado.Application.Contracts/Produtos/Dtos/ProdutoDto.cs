using System;
using Volo.Abp.Application.Dtos;

namespace GuiaMercado.Produtos
{
    public class ProdutoDto : AuditedEntityDto<long>
    {
        public string Descricao { get; set; }
        public decimal UltimoPreco { get; set; }
        public DateTime UltimaCompra { get; set; }
        public long CategoriaId { get; set; }
        public string CategoriaDescricao { get; set; }
    }
}
