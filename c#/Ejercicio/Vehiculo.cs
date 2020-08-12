using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Vehiculo
    {
        private string marca;
        private string modelo;
        private double precio;

        public Vehiculo(string marca, string modelo, double precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
        }

        public string Marca { get => marca.ToString(); set => marca = value; }
        public string Modelo { get => modelo.ToString(); set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }

    }
}