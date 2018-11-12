using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Empresa { get; set; }
        public int IdFuncao { get; set; }
    }
}
