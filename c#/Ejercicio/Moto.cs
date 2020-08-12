using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Moto : Vehiculo
    {
        private string cilindrada;

        public Moto(string cilindrada, string marca, string modelo, double precio) : base(marca, modelo, precio)
        {
            this.Cilindrada = cilindrada;
        }

        public string Cilindrada { get => cilindrada.ToString(); set => cilindrada = value; }

    }
}
