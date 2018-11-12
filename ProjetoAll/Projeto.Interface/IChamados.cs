using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Model;

namespace Projeto.Interface
{
    public interface IChamados
    {
        bool ConsultaChamado(Int64 id);
        bool ConsultarTodosChamados(Int64 id);
    }
}
