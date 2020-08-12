using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Concesionaria consecionaria = new Concesionaria();
            Auto auto1 = new Auto(4, "Peugeot", "206", 200000.00);
            Moto moto1 = new Moto("125c", "Honda", "Titan", 60000.00);
            Auto auto2 = new Auto(5, "Peugeot", "208", 250000.00);
            Moto moto2 = new Moto("160c", "Yamaha", "YBR", 80500.00);

            bool agregar;
            agregar = consecionaria + auto1;
            agregar = consecionaria + moto1;
            agregar = consecionaria + auto2;
            agregar = consecionaria + moto2;

            consecionaria.PrintVehiculos();

            Console.WriteLine(Concesionaria.VehiculoMasCaro(consecionaria));
            Console.WriteLine(Concesionaria.VehiculoMasBarato(consecionaria));
            Console.WriteLine(Concesionaria.ModeloConLetra(consecionaria, "Y"));

            consecionaria.OrdenarPorPrecio();
            Console.WriteLine(consecionaria.MostrarOrdenado());
            
            Console.ReadKey();
        }
    }
}

