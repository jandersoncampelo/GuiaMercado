using GuiaMercado.Categorias;
using GuiaMercado.Produtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace GuiaMercado.Data
{
    public class GuiaMercadoDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Categoria, long> _categoriaRepository;
        private readonly IRepository<Produto, long> _produtoRepository;

        public GuiaMercadoDataSeedContributor(IRepository<Categoria, long> categoriaRepository,
                                              IRepository<Produto, long> produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _categoriaRepository.CountAsync() > 0)
                return;

            var categoriaList = new List<Categoria>
            {
                new Categoria { Descricao = "Hortifruti" },
                new Categoria { Descricao = "Bebidas" },
                new Categoria { Descricao = "Limpeza" },
                new Categoria { Descricao = "Proteinas" }
            };
            
            await _categoriaRepository.InsertManyAsync(categoriaList, true);

            var produtoList = new List<Produto>
            {
                new Produto { Descricao = "Produto1", UltimoPreco = 1.99M, UltimaCompra = new System.DateTime(2020, 1, 1), CategoriaId = 1 },
                new Produto { Descricao = "Produto2", UltimoPreco = 2.99M, UltimaCompra = new System.DateTime(2020, 1, 1), CategoriaId = 2 },
                new Produto { Descricao = "Produto3", UltimoPreco = 3.99M, UltimaCompra = new System.DateTime(2020, 1, 1), CategoriaId = 3 },
                new Produto { Descricao = "Produto4", UltimoPreco = 4.99M, UltimaCompra = new System.DateTime(2020, 1, 1), CategoriaId = 4 }
            };

            await _produtoRepository.InsertManyAsync(produtoList, true);
        }
    }
}
