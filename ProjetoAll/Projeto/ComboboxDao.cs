using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Model;
using System.Data;
using System.Web.UI.WebControls;

namespace Projeto
{
    public class ComboboxDao
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PIM;Data Source=NTB-SYS-003");

        public DataTable PreencheCombo(int Tipo,int Subtipo)
        {
            DataTable TbResultado = new DataTable();
            ChamadosModel cm = new ChamadosModel();

            StringBuilder sql = new StringBuilder();

            sql.Append("exec sp_PreencheComboBox @tipo") ;

            if (Subtipo != 0)
            {
                sql.Append(", @subtipo");
            }

            SqlCommand command = new SqlCommand(sql.ToString(), sqlcon);

            command.Parameters.Add("@tipo", SqlDbType.Int).Value = Tipo;
            command.Parameters.Add("@subtipo", SqlDbType.Int).Value = Subtipo;

            try
            {
                sqlcon.Open();
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows == true)
                {
                    TbResultado.Load(dr);
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


            return TbResultado;
        }
    }
}
