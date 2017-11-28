using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restful.Models
{
    public class Venda
    {
        private int id;
        private string data;
        private Cliente cliente;
        private Produto produto;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }
    }
}