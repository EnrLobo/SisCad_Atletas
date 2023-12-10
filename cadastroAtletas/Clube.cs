using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAtletas
{
    internal class Clube
    {
        string nomeClube;
        string cidadeClube;
        string estado;
        string filiado;

        public string NomeClube { get => nomeClube; set => nomeClube = value; }
        public string CidadeClube { get => cidadeClube; set => cidadeClube = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Filiado { get => filiado; set => filiado = value; }
    }
}
