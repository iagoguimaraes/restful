using Restful.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Restful.Daos
{
    public class ClienteDao
    {
        public static void Cadastrar(Cliente cliente)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", cliente.Id.ToString());
                parameters.Add("p_nome", cliente.Nome);
               
                MySQLHelper.ExecuteDataTable("proc_ins_cliente", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Cliente> Obter()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                DataTable r = MySQLHelper.ExecuteDataTable("proc_sel_ocorrencias");

                foreach (DataRow row in r.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(row["id"]);
                    cliente.Nome = row["nome"].ToString();
                    clientes.Add(cliente)
                }

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Editar(Cliente cliente)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                parameters.Add("p_id", cliente.Id.ToString());
                parameters.Add("p_nome", cliente.Nome);

                MySQLHelper.ExecuteDataTable("proc_upd_cliente", parameters);
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

                MySQLHelper.ExecuteDataTable("proc_del_cliente", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}