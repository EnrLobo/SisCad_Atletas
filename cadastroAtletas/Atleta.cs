using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAtletas
{
    internal class Atleta
    {
        string nome;
        string data_nasc;
        string cidade;
        string federacao;
        int clube;

        public string Nome { get => nome; set => nome = value; }
        public string Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Federacao { get => federacao; set => federacao = value; }
        public int Clube { get => clube; set => clube = value; }
    }
}
