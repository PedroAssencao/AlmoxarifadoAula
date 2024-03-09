using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class ProdutoRepositroy : BaseRepository<Produto>
    {
        protected readonly CategoriaRepository _categoria;

        public ProdutoRepositroy(CategoriaRepository categoria, AlmoxarifadoContext context) : base(context)
        {
            _categoria = categoria;
        }

        public async Task<List<Produto>> GetProdutos()
        {
            var a = await GetAll();
            foreach (var item in a)
            {
                var b = await _categoria.GetCategoriaPorId(Convert.ToInt32(item.CatId));
                item.Cat = b;
            }
            return a;
        }

        public async Task<Produto> AdicionarImagem(ProdutoView model)
        {
            var caminho = Path.Combine("Storage", model.ProImg.FileName);
            using Stream filestream = new FileStream(caminho, FileMode.Create);
            model.ProImg.CopyTo(filestream);
            var produto = new Produto();
            produto.ProNome = model.ProNome;
            produto.ProImg = caminho;
            produto.ProEstoque = model.ProEstoque;
            produto.CatId = model.CatId;
            return await Adicionar(produto);

        }

        public async Task<Produto> AtualizarProduto(ProdutoView model)
        {
            var caminho = Path.Combine("Storage", model.ProImg.FileName);
            using Stream filestream = new FileStream(caminho, FileMode.Create);
            model.ProImg.CopyTo(filestream);
            var produto = new Produto();
            produto.ProNome = model.ProNome;
            produto.ProImg = caminho;
            produto.ProEstoque = model.ProEstoque;
            produto.CatId = model.CatId;
            produto.ProId = model.ProId;
            return await Update(produto);

        }
    }
}
