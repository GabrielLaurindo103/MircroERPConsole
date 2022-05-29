using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroERPConsole.Models;

namespace MicroERPConsole.Models
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public char Situacao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public Produto(int codigo, string descricao, char situacao, UnidadeMedida unidadeMedida)
        {
            if (unidadeMedida.Ativo == '1')
            {
                Codigo = codigo;
                Descricao = descricao;
                Situacao = situacao;
                UnidadeMedida.Codigo = unidadeMedida.Codigo;
            }
            else
            {
                throw new ArgumentException($"Não foi possível completar o cadastro do produto. \nSituação unidade medida código: {unidadeMedida.Codigo} | {unidadeMedida.Descricao} está inativo."); // BREAK NA EXECUÇÃO DO PROGRAMA
            }
        }
        public void ConsultarProduto()
        {
            Console.WriteLine("Código Produto {-10}| Descrição Produto {-10}| Situacao {-10}| Código Unidade de Medida {-10} | Sigla Unidade de Medida {-10} |");
            Console.WriteLine(Codigo);
            Console.WriteLine(Descricao);
            Console.WriteLine(Situacao);
            Console.WriteLine(UnidadeMedida.Codigo);
            Console.WriteLine(UnidadeMedida.Sigla);
        }
    }
}
