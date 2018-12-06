using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projeto.Dao
{
    public class LoginDao
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PIM;Data Source=NTB-SYS-004");

        public bool FazerLoginDao()
        {
            bool ret = false;

            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PIM;Data Source=ENIELSONTI");
            SqlCommand command = new SqlCommand("select 1 from usuarios where cod_usuario=1", sqlcon);

            try
            {
                sqlcon.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows == true){ ret = true;}

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }


            return ret;
        }

        public string MontarMenu(int Funcao)
        {
           string menu = "";

            DataTable TabelaMenu = new DataTable();

            StringBuilder sql = new StringBuilder();

            sql.Append(" SELECT");
            sql.Append("    Nome,");
            sql.Append("    Link");
            sql.Append(" from TELA_USUARIOS AS T1");
            sql.Append(" JOIN TELAS_MENU AS T2");
            sql.Append("    ON T1.IdTelaRef = T2.IdTela");
            sql.Append(" WHERE 1 = 1");
            sql.Append(" AND IdFuncaoRef = @IdFuncao");


            SqlCommand sqlcom = new SqlCommand(sql.ToString(), sqlcon);
            sqlcom.Parameters.Add("@IdFuncao", SqlDbType.Int).Value = Funcao;

            try
            {
                sqlcon.Open();
                SqlDataReader dr = sqlcom.ExecuteReader();
                

                if (dr.HasRows == true)
                {
                    TabelaMenu.Load(dr);

                    foreach (DataRow l in TabelaMenu.Rows)
                    {
                        menu = menu+ "<li> <a runat=" + ""+"'server'"+"" + " href='" + l["Link"].ToString() + "'>" + l["Nome"].ToString() + "</a></li>";
                    }
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

           return menu;


        }


    }
}
