using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dao;
using Projeto.Model;
using System.Data;

namespace Projeto.Business
{
    public class ComboboxBll
    {
        ComboboxDao cd = new ComboboxDao();

        public DataTable PreencheCombo(int Tipo)
        {
            DataTable TbResultado = new DataTable();
            try
            {
                TbResultado = cd.PreencheCombo(Tipo,0);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return TbResultado;
        }


        public DataTable PreencheCombo(int Tipo,int SubTipo)
        {
            DataTable TbResultado = new DataTable();
            try
            {
                TbResultado = cd.PreencheCombo(Tipo,SubTipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return TbResultado;
        }


    }
}
