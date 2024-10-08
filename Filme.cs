using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_POO
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Unidades  { get; set; }

        public Filme(string titulo, string genero, int unidades)
        {
            Titulo = titulo;
            Genero = genero;
            Unidades = unidades;
        }
    }
}
