using APIControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIControleEstoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly Contexto _context;

        public ProdutoController(Contexto context)
        {
            _context = context;
        }

        public static List<Produto> ProdutoList = new List<Produto>();

        [HttpGet()]
        public IEnumerable<Produto> get()
        {
            return _context.Produto.ToList();
     
        }


        [HttpPost()]
        public Produto Post([FromBody] Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            var deletedProduct = _context.Produto.FirstOrDefault(x => x.Id == index);
            if (deletedProduct == null)
            {
                return;
            }
            _context.Produto.Remove(deletedProduct);
            _context.SaveChanges();
        }

        [HttpPut("{index}")]
        public IActionResult Put(int index, [FromBody] Produto updatedProduto)
        {
            var product = _context.Produto.FirstOrDefault(x => x.Id == index);
            if(product == null)
            {
                return NotFound();
            }
            product.Nome = updatedProduto.Nome;
            product.Descricao = updatedProduto.Descricao;
            product.Preco = updatedProduto.Preco;
            product.Quantidade = updatedProduto.Quantidade;
            product.Categoria = updatedProduto.Categoria;

            var result = _context.Produto.Update(product);
            if (result == null)
            {
                return StatusCode(500, "Erro interno no servidor");
            }
            _context.SaveChanges();
            return NoContent();
        }


    }
}