using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Restful.Daos;

namespace Restful.Controllers
{
    public class ProdutoController : ApiController
    {
        static List<Produto> produtos = new List<Produto>();

        // GET: api/Produto
        public List<Produto> Get()
        {
            return produtos;
            //return ProdutoDao.Obter();
        }

        // POST: api/Produto
        public void Post([FromBody]Produto produto)
        {
            produto.Id = produtos.DefaultIfEmpty(new Produto()).Max(c => c.Id) + 1;
            produtos.Add(produto);
            //ProdutoDao.Cadastrar(produto);
        }

        // PUT: api/Produto/5
        public void Put(int id, [FromBody]Produto produto)
        {
            int index = produtos.FindIndex(c => c.Id == id);
            if (index >= 0)
                produtos[index] = produto;
            //ProdutoDao.Editar(produto);
        }

        // DELETE: api/Produto/5
        public void Delete(int id)
        {
            int index = produtos.FindIndex(c => c.Id == id);
            if (index >= 0)
                produtos.RemoveAt(index);
            //ProdutoDao.Remover(id);
        }
    }
}
