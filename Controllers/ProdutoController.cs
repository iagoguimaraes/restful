using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class ProdutoController : ApiController
    {
        List<Produto> produtos = new List<Produto>();

        // GET: api/Produto
        public List<Produto> Get()
        {
            return produtos;
        }

        // GET: api/Produto/5
        public Produto Get(int id)
        {
            return produtos.Where(c => c.Id == id).First();
        }

        // POST: api/Produto
        public void Post([FromBody]Produto produto)
        {
            produtos.Add(produto);
        }

        // PUT: api/Produto/5
        public void Put(int id, [FromBody]Produto produto)
        {
            int index = produtos.FindIndex(c => c.Id == id);
            if (index > 0)
                produtos[index] = produto;
            else
                produtos.Add(produto);
        }

        // DELETE: api/Produto/5
        public void Delete(int id)
        {
            int index = produtos.FindIndex(c => c.Id == id);
            if (index > 0)
                produtos.RemoveAt(index);
        }
    }
}
