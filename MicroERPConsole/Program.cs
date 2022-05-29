using System;
using System.Globalization;
using MicroERPConsole.Models;

namespace MicroERPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UnidadeMedida unidadeMedida = new UnidadeMedida();

            unidadeMedida.CadastrarUnidadeMedida();

        }
    }
}