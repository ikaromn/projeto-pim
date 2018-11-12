using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dao;

namespace Projeto.Business
{
    public class LoginBll
    {
        private LoginDao ld = new LoginDao();

        public bool FazerLogin()
        {
            try
            {
                bool ret = false;

                ret=ld.FazerLoginDao();

                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
