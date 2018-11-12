using Projeto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 

namespace Projeto.Web2._0
{
    public partial class SiteMaster : MasterPage
    {
        MenuBll mb = new MenuBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Teste.InnerHtml = mb.MontarMenu(1);
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Teste.InnerHtml = mb.MontarMenu(1);
        }


    }
}