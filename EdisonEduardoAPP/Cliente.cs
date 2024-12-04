using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdisonEduardoClass
{
    internal class Cliente
    {
    }
}

    public class Cliente
    {
        // Propriedades da classe
        public int IdCliente { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        // Banco de dados simulado (em memória)
        private static List<Cliente> clientes = new List<Cliente>();
        private static int contadorId = 1;

        // Método para inserir um novo cliente
        public void Inserir()
        {
            IdCliente = contadorId++;
            clientes.Add(this);
            Console.WriteLine("Cliente inserido com sucesso!");
        }

        // Método para alterar os dados de um cliente
        public void Alterar(int id)
        {
            Cliente cliente = clientes.Find(c => c.IdCliente == id);
            if (cliente != null)
            {
                cliente.NomeCompleto = NomeCompleto;
                cliente.Email = Email;
                cliente.Telefone = Telefone;
                cliente.Endereco = Endereco;
                Console.WriteLine("Cliente alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        // Método para buscar cliente por ID
        public static Cliente ObterPorId(int id)
        {
            return clientes.Find(c => c.IdCliente == id);
        }

        // Método para listar todos os clientes
        public static List<Cliente> Listar()
        {
            return clientes;
        }
    }
