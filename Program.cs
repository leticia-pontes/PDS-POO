using PDS_POO;
using System;

namespace PDS_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Locadora locadora = new Locadora();

            Cliente cliente1 = new Cliente("Laura");
            Cliente cliente2 = new Cliente("Letícia");

            Filme filme1 = new Filme("Rei Leão", "Animação", 2);
            Filme filme2 = new Filme("O Conde de Monte Cristo", "Drama", 1);

            locadora.Clientes.Add(cliente1);
            locadora.Clientes.Add(cliente2);

            locadora.Filmes.Add(filme1);
            locadora.Filmes.Add(filme2);
        }
    }
}
