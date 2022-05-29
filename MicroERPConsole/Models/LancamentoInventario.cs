using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERPConsole.Models
{
    internal class LancamentoInventario : Inventario
    {

        public Inventario Inventario { get; set; }

        public int Quantidade { get; set; }

        public void Incluir(Inventario inventario, int quantidade)
        {
            Inventario = inventario;
            Quantidade += quantidade;
        }

        public void Excluir(Inventario inventario, int quantidade)
        {
            Inventario = inventario;
            Quantidade -= quantidade;
        }

        public void ConsultarQuantidade()
        {
            Inventario.ConsultarInventario();
            Console.Write($"| Quantidade: {Quantidade}");
        }
    }
}
