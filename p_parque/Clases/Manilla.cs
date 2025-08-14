using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Manilla
    {
        private int id;
        private ushort saldo_puntos;

        public Manilla()
        {
            id= new Random().Next(1000000,9000000);
            Saldo_puntos = 0;
        }

        public ushort Saldo_puntos { get => saldo_puntos; set => saldo_puntos = value; }
    }
}
