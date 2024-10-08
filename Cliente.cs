using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_POO
{
    public class Cliente
    {
        public string Nome {  get; set; }
        public List<Filme> Filmes { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
            Filmes = new List<Filme>();
        }

        public void AlugarFilme(Filme filme, Locadora locadora)
        {
            bool filmeExists = locadora.VerificarFilmeDisponivel(filme);

            if (filmeExists) 
            {
                int unidadesDisponiveis = locadora.VerificarUnidadesFilme(filme);
            }
        }
    }
}
