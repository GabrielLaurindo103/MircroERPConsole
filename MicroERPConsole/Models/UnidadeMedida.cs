using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERPConsole.Models
{
    class UnidadeMedida
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Sigla{ get; set; }
        public char Ativo { get; set; }

        public string[,] vetor = new string[2, 4];

        public void CadastrarUnidadeMedida()
        {

            Console.WriteLine("************** U N I D A D E - D E - M E D I D A **************");

            Console.WriteLine();

            for (int codigo = 0; codigo < 2; codigo++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    switch (coluna)
                    {
                        case 0:
                            Codigo = codigo;
                            vetor[codigo, coluna] = Convert.ToString(Codigo);
                            break;
                        case 1:
                            Console.Write("Digite a descrição: ");
                            Descricao = Console.ReadLine();
                            vetor[codigo, coluna] = Descricao;
                            break;
                        case 2:
                            Console.Write("Digite a sigla: ");
                            Sigla = Console.ReadLine();
                            vetor[codigo, coluna] = Sigla;
                            break;
                        default:
                            Console.Write("Ativo (1-Sim ou 0-Não): ");
                            Ativo = Convert.ToChar(Console.ReadLine());
                            vetor[codigo, coluna] = Convert.ToString(Ativo);
                            break;
                    }
                }
                Console.WriteLine("Unidade de medida Gravada!");
                Console.WriteLine();
            }
            Console.Clear();
            ImprimirUnidadeMedida();
        }
        public void ImprimirUnidadeMedida()
        {
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} | {3,-10}| ", "CÓDIGO", "DESCRIÇÃO", "SIGLA", "ATIVO");
            Console.WriteLine(new string('-', 65));

            for (int linha = 0; linha < 2; linha++)
            {
                Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} | {3,-10}|", vetor[linha, 0], vetor[linha, 1], vetor[linha, 2], vetor[linha, 3]);
                Console.WriteLine(new string('-', 65));
            }
        }
    }
}