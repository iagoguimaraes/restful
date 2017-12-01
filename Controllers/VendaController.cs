using Restful.Daos;
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
            //return VendaDao.Obter();
        }

        // POST: api/Venda
        public void Post([FromBody]Venda venda)
        {
            venda.Id = vendas.DefaultIfEmpty(new Venda()).Max(c => c.Id) + 1;
            vendas.Add(venda);
            //VendaDao.Cadastrar(venda);
        }

        // PUT: api/Venda/5
        public void Put(int id, [FromBody]Venda venda)
        {
            int index = vendas.FindIndex(c => c.Id == id);
            if (index >= 0)
                vendas[index] = venda;
            //VendaDao.Editar(venda);
        }

        // DELETE: api/Venda/5
        public void Delete(int id)
        {
            int index = vendas.FindIndex(c => c.Id == id);
            if (index >= 0)
                vendas.RemoveAt(index);
            //VendaDao.Remover(id);
        }

    }
}
