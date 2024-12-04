using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EdisonEduardoClass
{
    public class Placa
    {
        // Propriedades da classe
        public int IdPlaca { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }

        // Banco de dados simulado (em memória)
        private static List<Placa> placas = new List<Placa>();
        private static int contadorId = 1;

        // Método para inserir uma nova placa
        public void Inserir()
        {
            IdPlaca = contadorId++;
            placas.Add(this);
            Console.WriteLine("Placa inserida com sucesso!");
        }

        // Método para alterar os dados de uma placa
        public void Alterar(int id)
        {
            Placa placa = placas.Find(p => p.IdPlaca == id);
            if (placa != null)
            {
                placa.Tipo = Tipo;
                placa.Tamanho = Tamanho;
                placa.Preco = Preco;
                Console.WriteLine("Placa alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa não encontrada!");
            }
        }

        // Método para buscar placa por ID
        public static Placa ObterPorId(int id)
        {
            return placas.Find(p => p.IdPlaca == id);
        }

        // Método para listar todas as placas
        public static List<Placa> Listar()
        {
            return placas;
        }
    }
}