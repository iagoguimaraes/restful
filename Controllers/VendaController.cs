using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class VendaController : ApiController
    {
        static List<Venda> vendas = new List<Venda>();

        // GET: api/Venda
        public List<Venda> Get()
        {
            return vendas;
        }

        // GET: api/Venda/5
        public Venda Get(int id)
        {
            return vendas.Where(c => c.Id == id).First();
        }

        // POST: api/Venda
        public void Post([FromBody]Venda venda)
        {
            venda.Id = vendas.DefaultIfEmpty(new Venda()).Max(c => c.Id) + 1;
            vendas.Add(venda);
        }

    }
}
