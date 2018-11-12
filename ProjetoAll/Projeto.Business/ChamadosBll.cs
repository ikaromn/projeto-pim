using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto;
using Projeto.Dao;
using Projeto.Model;


namespace Projeto.Business
{

    public class ChamadosBll
    {
        private ChamadosDao cd = new Projeto.ChamadosDao();
        

        public bool AbrirChamado(ChamadosModel model)
        {
            bool ret = false;
            try
            {
                ret = cd.AbrirChamado(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return ret;            
        }

        /// <summary>
        /// Metodo de consulta do chamado
        /// </summary>
        /// <param name="model">parametro do tipo modelo</param>
        /// <returns></returns>
        public List<ChamadosModel> ConsultaChamado(ChamadosModel model)
        {

            try
            {
                return cd.ConsultaChamado(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sobrecarga Método ConsultaChamado
        /// </summary>
        /// <param name="model">parametro do tipo modelo</param>
        /// <param name="texto_procura">texto a ser procurado</param>
        /// <returns></returns>
        public List<ChamadosModel> ConsultaChamado(ChamadosModel model, string texto_procura)
        {

            try
            {
                List<ChamadosModel> lstChamados = ConsultaChamado(model);


                return lstChamados.Where(x => x.Descricao == texto_procura).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para listar todos os Chamados
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ChamadosModel> ConsultaTodosChamado(ChamadosModel model)
        {

            try
            {
                return cd.ConsultaTodosChamado(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para fechar chamado
        /// </summary>
        /// <param name="model">Parâmetro do tipo Modelo</param>
        /// <returns></returns>
        public bool FecharChamado(ChamadosModel model)
        {
            bool ret = false;
            try
            {
                ret = cd.FecharChamado(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        ///  Metodo de atualizar chamados para atendimento
        /// </summary>
        /// <param name="model"> Parâmetro do tipo Modelo</param>
        /// <returns></returns>
        public bool AtenderChamado(ChamadosModel model)
        {
            bool ret = false;
            try
            {
                ret = cd.AtenderChamado(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AlterarChamado(ChamadosModel model)
        {
            bool ret = false;
            try
            {
                ret = cd.AlterarChamado(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

    }
}
