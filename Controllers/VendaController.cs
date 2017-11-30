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
            vendas.Add(venda);
        }

        // PUT: api/Venda/5
        public void Put(int id, [FromBody]Venda venda)
        {
            int index = vendas.FindIndex(c => c.Id == id);
            if (index > 0)
                vendas[index] = venda;
            else
                vendas.Add(venda);
        }

        // DELETE: api/Venda/5
        public void Delete(int id)
        {
            int index = vendas.FindIndex(c => c.Id == id);
            if (index > 0)
                vendas.RemoveAt(index);
        }
    }
}
