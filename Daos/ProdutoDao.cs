using Restful.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Restful.Daos
{
    public class ProdutoDao
    {
        public static void Cadastrar(Produto produto)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", produto.Id.ToString());
                parameters.Add("p_descricao", produto.Descricao);

                MySQLHelper.ExecuteDataTable("proc_ins_produto", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Produto> Obter()
        {
            try
            {
                List<Produto> produtos = new List<Produto>();
                DataTable r = MySQLHelper.ExecuteDataTable("proc_sel_ocorrencias");

                foreach (DataRow row in r.Rows)
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(row["id"]);
                    produto.Descricao = row["descricao"].ToString();
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Editar(Produto produto)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", produto.Id.ToString());
                parameters.Add("p_descricao", produto.Descricao);

                MySQLHelper.ExecuteDataTable("proc_upd_produto", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Remover(int Id)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("p_id", Id.ToString());

                MySQLHelper.ExecuteDataTable("proc_del_produto", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}