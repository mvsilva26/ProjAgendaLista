using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaLista
{
    internal class Telefone
    {

        public string Tipo { get; set; }
        public int Ddd { get; set; }
        public int Numero { get; set; }

        public Telefone(string tipo, int ddd, int numero)
        {
            Tipo = tipo;
            Ddd = ddd;
            Numero = numero;
        }

        public override string ToString()
        {
            return Tipo + ":" + Ddd + " " +Numero;
        }

    }
}
