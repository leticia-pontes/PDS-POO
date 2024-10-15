using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_POO
{
    public class Locadora
    {
        public List<Cliente> Clientes {  get; set; }
        public List<Filme> Filmes { get; set; }

        public Locadora() {
            Clientes = new List<Cliente>();
            Filmes = new List<Filme>();
        }

        public bool VerificarFilmeDisponivel(Filme filme)
        {
            foreach (var f in Filmes)
            {
                if (f == filme)
                {
                    return true;
                }
            }

            return false;
        }

        public int VerificarUnidadesFilme(Filme filme)
        {
            return filme.Unidades;
        }
    }
}
