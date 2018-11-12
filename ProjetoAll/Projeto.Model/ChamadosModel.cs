using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class ChamadosModel
    {
        public string link { get; set; }
        public int IdChamado            { get; set; }
        public int IdProblema           { get; set; }
        public string Problema          { get; set; }
        public int IdArea               { get; set; }
        public string Area              { get; set; }
        public int IdEmpresa            { get; set; }
        public string Empresa           { get; set; }
        public string Descricao         { get; set; }
        public string Solicitante       { get; set; }
        public string Status            { get; set; }
        public DateTime DataAbertura    { get; set; }
        public DateTime DataFechamento  { get; set; }
        public long TelefoneContato     { get; set; }
        public string Operador          { get; set; }
        public string MensagemALt       { get; set; }
        public string MensagemFinal     { get; set; }
    }
}
