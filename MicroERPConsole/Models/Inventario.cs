using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERPConsole.Models
{
    internal class Inventario
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public LocalEstoque LocalEstoque { get; set; }
        public Produto Produto { get; set; }

        public Inventario()
        {
        }

        public Inventario(int codigo, string descricao, LocalEstoque localEstoque) 
        {
            if (localEstoque.Ativo == '1')
            {
                Codigo = codigo;
                Descricao = descricao;
                LocalEstoque.Codigo = localEstoque.Codigo;
            }
            else
            {
                throw new ArgumentException ($"Não foi possível completar o cadastro de inventário. \nLocal de estoque: {localEstoque.Codigo} | Situação: {localEstoque.Ativo} está inativo."); // BREAK NA EXECUÇÃO DO PROGRAMA
            }
        }

        public void ConsultarInventario()
        {
            Console.WriteLine($"Código inventarário: {Codigo} | Descrição: {Descricao}");
        }
    }
}
