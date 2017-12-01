using Restful.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Restful.Daos
{
    public class VendaDao
    {
        public static void Cadastrar(Venda venda)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", venda.Id.ToString());
                parameters.Add("p_data", venda.Data);
                parameters.Add("p_id_produto", venda.Produto.Id.ToString());
                parameters.Add("p_id_cliente", venda.Cliente.Id.ToString());

                MySQLHelper.ExecuteDataTable("proc_ins_venda", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Venda> Obter()
        {
            try
            {
                List<Venda> vendas = new List<Venda>();
                DataTable r = MySQLHelper.ExecuteDataTable("proc_sel_ocorrencias");

                foreach (DataRow row in r.Rows)
                {
                    Venda venda = new Venda();
                    Produto produto = new Produto();
                    Cliente cliente = new Cliente();

                    venda.Id = Convert.ToInt32(row["id"]);
                    venda.Data = row["data"].ToString();

                    cliente.Id = Convert.ToInt32(row["id_cliente"]);
                    cliente.Nome = row["nome_cliente"].ToString();

                    produto.Id = Convert.ToInt32(row["id_produto"]);
                    produto.Descricao = row["descricao_produto"].ToString();

                    venda.Produto = produto;
                    venda.Cliente = cliente;

                    vendas.Add(venda);
                }

                return vendas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Editar(Venda venda)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", venda.Id.ToString());
                parameters.Add("p_data", venda.Data);
                parameters.Add("p_id_produto", venda.Produto.Id.ToString());
                parameters.Add("p_id_cliente", venda.Cliente.Id.ToString());

                MySQLHelper.ExecuteDataTable("proc_upd_venda", parameters);
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

                MySQLHelper.ExecuteDataTable("proc_del_venda", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}