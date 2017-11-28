using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restful.Models
{
    public class Produto
    {
        private int id;
        private string descricao;
        private double preco;

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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }
    }
}