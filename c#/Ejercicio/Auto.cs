using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Auto : Vehiculo
    {
        private int puertas;

        public Auto(int puertas, string marca, string modelo, double precio) : base(marca, modelo, precio)
        {
            this.Puertas = puertas;
        }

        public int Puertas { get => puertas; set => puertas = value; }

    }
}
