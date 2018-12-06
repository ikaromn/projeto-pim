using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Interface;
using System.Data.SqlClient;
using Projeto.Model;
using System.Data;
using System.Web.UI.WebControls;

namespace Projeto
{
    public class ChamadosDao//: IChamados
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PIM;Data Source=NTB-SYS-004");

        public List<ChamadosModel> ConsultaChamado(ChamadosModel model)
        {
            var ret = new List<ChamadosModel>();
            DataTable TableChamados = new DataTable();
            ChamadosModel cm = new ChamadosModel();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("    c.IdChamado,");
            sql.Append("    p.Problema,");
            sql.Append("    a.Area,");
            sql.Append("    e.Empresa,");
            sql.Append("    c.Descricao,");
            sql.Append("    c.Solicitante,");
            sql.Append("    c.Status,");
            sql.Append("    c.TelefoneContato,");
            sql.Append("    c.operador,");
            sql.Append("    c.Mensagemalt, ");
            sql.Append("    c.Dataabertura, ");
            sql.Append("    c.Datafechamento ");
            sql.Append("FROM chamados as c ");
            sql.Append("join PROBLEMAS as p ");
            sql.Append("    on p.IdProblema = c.IdProblema ");
            sql.Append("join AREA as a ");
            sql.Append("    on a.IdArea = c.IdArea ");
            sql.Append("join EMPRESA as e ");
            sql.Append("    on e.IdEmpresa = c.IdEmpresa ");
            sql.Append("where idChamado = @IdChamado ");

            SqlCommand command = new SqlCommand(sql.ToString(), sqlcon);

            command.Parameters.Add("@IdChamado", SqlDbType.Int).Value = model.IdChamado;

            try
            {
                sqlcon.Open();
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows == true) {

                    TableChamados.Load(dr);

                    foreach (DataRow dt in TableChamados.Rows)
                    {
                        cm.link = null; // dt["Link"].ToString();
                        cm.IdChamado = (Int32)dt["IdChamado"];
                        cm.Problema = dt["Problema"].ToString();
                        cm.Area = dt["Area"].ToString();
                        cm.Empresa = dt["Empresa"].ToString();
                        cm.Descricao = dt["Descricao"].ToString();
                        cm.Status = dt["Status"].ToString();
                        cm.DataAbertura = (DateTime)dt["DataAbertura"];
                        cm.DataFechamento = (DateTime)dt["DataFechamento"];
                        cm.TelefoneContato = (Int64)dt["TelefoneContato"];
                        cm.Solicitante = dt["Solicitante"].ToString();

                        ret.Add(cm);
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }


            return ret;
        }

        public List<ChamadosModel> ConsultaTodosChamado(ChamadosModel model)
        {
            var ret = new List<ChamadosModel>();
            DataTable TableChamados = new DataTable();


            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("    c.IdChamado,");
            sql.Append("    p.Problema,");
            sql.Append("    a.Area,");
            sql.Append("    e.Empresa,");
            sql.Append("    c.Descricao,");
            sql.Append("    c.Solicitante,");
            sql.Append("    c.Status,");
            sql.Append("    c.TelefoneContato,");
            sql.Append("    c.operador,");
            sql.Append("    c.Mensagemalt, ");
            sql.Append("    c.Dataabertura, ");
            sql.Append("    c.Datafechamento ");
            sql.Append("FROM chamados as c ");
            sql.Append("join PROBLEMAS as p ");
            sql.Append("    on p.IdProblema = c.IdProblema ");
            sql.Append("join AREA as a ");
            sql.Append("    on a.IdArea = c.IdArea ");
            sql.Append("join EMPRESA as e ");
            sql.Append("    on e.IdEmpresa = c.IdEmpresa ");

            SqlCommand command = new SqlCommand(sql.ToString(), sqlcon);

            try
            {
                sqlcon.Open();
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows == true)
                {

                    TableChamados.Load(dr);

                    foreach (DataRow dt in TableChamados.Rows)
                    {
                        ChamadosModel cm = new ChamadosModel();

                        cm.link = null; // dt["Link"].ToString();
                        cm.IdChamado = (Int32)dt["IdChamado"];
                        cm.Problema = dt["Problema"].ToString();
                        cm.Area = dt["Area"].ToString();
                        cm.Empresa = dt["Empresa"].ToString();
                        cm.Descricao = dt["Descricao"].ToString();
                        cm.Status = dt["Status"].ToString();
                        cm.DataAbertura = (DateTime)dt["DataAbertura"];
                        cm.DataFechamento = (DateTime)dt["DataFechamento"];
                        cm.TelefoneContato = (Int64)dt["TelefoneContato"];
                        cm.Solicitante = dt["Solicitante"].ToString();

                        ret.Add(cm);


                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }


            return ret;
        }


        public bool FecharChamado(ChamadosModel model)
        {
            bool ret = false;
            
            SqlCommand command = new SqlCommand("UPDATE PIM.DBO.CHAMADOS SET STATUS='ATENDIDO', OPERADOR= @Operador ,MensagemFinal= @Mensagem_Final where idChamado=@IdChamado ", sqlcon);
                                                

            command.Parameters.Add("@Operador", SqlDbType.VarChar).Value = model.Operador;
            command.Parameters.Add("@Mensagem_Final", SqlDbType.VarChar).Value = model.MensagemFinal;
            command.Parameters.Add("@IdChamado", SqlDbType.Int).Value = model.IdChamado;

            try
            {
                sqlcon.Open();
                command.ExecuteNonQuery();
                ret = true;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

            return ret;
        }

        public bool AbrirChamado(ChamadosModel model)
        {
            bool ret = false;
            
            SqlCommand command = new SqlCommand("INSERT INTO CHAMADOS(IdProblema,IdArea,IdEmpresa,Descricao,Solicitante,TelefoneContato,Datafechamento) " +
                                                "VALUES (@IdProblema,@IdArea,@IdEmpresa,@Descricao,@Solicitante,@Telefone,getdate()+5)", sqlcon);

            command.Parameters.Add("@IdProblema", SqlDbType.Int).Value = model.IdProblema;
            command.Parameters.Add("@IdArea", SqlDbType.Int).Value = model.IdArea;
            command.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = model.IdEmpresa;
            command.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = model.Descricao;
            command.Parameters.Add("@Solicitante", SqlDbType.VarChar).Value = model.Solicitante;
            command.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = model.TelefoneContato;
            try
            {
                sqlcon.Open();
                command.ExecuteNonQuery();
                ret = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

            return ret;
        }

        public bool AtenderChamado(ChamadosModel model)
        {
            bool ret = false;
            

            SqlCommand command = new SqlCommand("UPDATE CHAMADOS SET OPERADOR=@Operador,status='CHAMADO EM ATENDIMENTO' ,mensagemalt='Chamado em Análise'  where idchamado=@idchamado", sqlcon);


            command.Parameters.Add("@IdChamado", SqlDbType.Int).Value = model.IdChamado;
            command.Parameters.Add("@Operador", SqlDbType.VarChar).Value = model.Operador;

            try
            {
                sqlcon.Open();
                command.ExecuteNonQuery();
                ret = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

            return ret;
        }

        public bool AlterarChamado(ChamadosModel model)
        {
            bool ret = false;

            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE C");
            sql.Append("SET IdProblema = @IdProblema");
            sql.Append(", IdArea = @IdArea");
            sql.Append(", IdEmpresa = @IdEmpresa");
            sql.Append(", Descricao = @Descricao");
            sql.Append(", Solicitante = @Solicitante");
            sql.Append(", TelefoneContato = @TelefoneContato");
            sql.Append(", operador = @operador");
            sql.Append(", Mensagemalt = @Mensagemalt");
            sql.Append("FROM[PIM].[dbo].[CHAMADOS] AS C");
            sql.Append("WHERE IdChamado = @IdChamado");

            SqlCommand command = new SqlCommand(sql.ToString(), sqlcon);

            command.Parameters.Add("@IdChamado", SqlDbType.Int).Value = model.IdChamado;
            command.Parameters.Add("@Operador", SqlDbType.VarChar).Value = model.Operador;
            command.Parameters.Add("@IdProblema", SqlDbType.Int).Value = model.IdProblema;
            command.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = model.IdEmpresa;
            command.Parameters.Add("@IdArea", SqlDbType.Int).Value = model.IdArea;
            command.Parameters.Add("@Solicitante", SqlDbType.VarChar).Value = model.Solicitante;
            command.Parameters.Add("@TelefoneContato", SqlDbType.BigInt).Value = model.TelefoneContato;
            command.Parameters.Add("@Mensagemalt", SqlDbType.VarChar).Value = model.MensagemALt;

   
            try
            {
                sqlcon.Open();
                command.ExecuteNonQuery();
                ret = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }

            return ret;
        }






    }
}
