using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class ClienteController : ApiController
    {

        List<Cliente> clientes = new List<Cliente>();

        // GET: api/Cliente
        public List<Cliente> Get()
        {
            return clientes;
        }

        // GET: api/Cliente/5
        public Cliente Get(int id)
        {
            return clientes.Where(c => c.Id == id).First();
        }

        // POST: api/Cliente
        public void Post([FromBody]Cliente cliente)
        {
            clientes.Add(cliente);
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]Cliente cliente)
        {
            int index = clientes.FindIndex(c => c.Id == id);
            if (index > 0)
                clientes[index] = cliente;
            else
                clientes.Add(cliente);
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            int index = clientes.FindIndex(c => c.Id == id);
            if (index > 0)
                clientes.RemoveAt(index);
        }
    }
}
