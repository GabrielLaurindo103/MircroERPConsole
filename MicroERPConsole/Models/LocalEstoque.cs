using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERPConsole.Models
{
    class LocalEstoque 
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public char Ativo { get; set; }

        public LocalEstoque()
        {
        }
        public LocalEstoque(int codigo, string descricao, char ativo)
        {
            Codigo = codigo;
            Descricao = descricao;
            Ativo = ativo;
        }
    }
}
