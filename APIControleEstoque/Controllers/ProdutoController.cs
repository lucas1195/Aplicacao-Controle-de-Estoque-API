using APIControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIControleEstoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        public ProdutoController()
        {
        }

        public static List<Produto> ProdutoList = new List<Produto>();

        [HttpGet()]
        public IEnumerable<Produto> get()
        {
            return ProdutoList.ToList();
     
        }


        [HttpPost()]
        public Produto Post([FromBody] Produto produto)
        {
            ProdutoList.Add(produto);
            return produto;
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            ProdutoList.RemoveAt(index);
        }

        [HttpPut("{index}")]
        public void Put(int index, [FromBody] Produto updatedProduto)
        {
            ProdutoList[index] = updatedProduto;
        }


    }
}