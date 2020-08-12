using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Concesionaria
    {
        public List<Vehiculo> listaVehiculos;

        public Concesionaria()
        {
            listaVehiculos = new List<Vehiculo>();
        }

        public static bool operator +(Concesionaria f, Vehiculo vehiculo)
        {
            if (f.listaVehiculos != null && (!f.listaVehiculos.Contains(vehiculo)))
            {
                f.listaVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }

        public static String VehiculoMasCaro(Concesionaria f)
        {
            if (f.ValidarDatos())
            {
                double max = f.listaVehiculos[0].Precio;
                Vehiculo vehiculoMasCaro = f.listaVehiculos[0];
                foreach (var item in f.listaVehiculos)
                {
                    if (item.Precio > max)
                    {
                        max = item.Precio;
                        vehiculoMasCaro = item;
                    }
                }
                return "Vehiculo mas caro: " + vehiculoMasCaro.Marca + " " + vehiculoMasCaro.Modelo;
            }
            else
                return "No hay información para mostrar";
        }

        public static String VehiculoMasBarato(Concesionaria f)
        {
            if(f.ValidarDatos())
            {
                double min = f.listaVehiculos[0].Precio;
                Vehiculo vehiculoMasBarato = f.listaVehiculos[0];
                foreach (var item in f.listaVehiculos)
                {
                    if (item.Precio < min)
                    {
                        min = item.Precio;
                        vehiculoMasBarato = item;
                    }
                }
                return "Vehiculo mas barato: " + vehiculoMasBarato.Marca + " " + vehiculoMasBarato.Modelo;
            } else
                return "No hay información para mostrar";
        }

        public static string ModeloConLetra(Concesionaria f, string letra)
        {
            if(f.ValidarDatos())
            {
                string c = letra.ToLower();
                foreach (var item in f.listaVehiculos)
                {
                    string aux = item.Modelo.ToLower();
                    if (aux.Contains(c))
                    {
                        return $"Vehículo que contiene en el modelo la letra ‘{letra}’: {item.Marca} {item.Modelo} {item.Precio.ToString("C")}";
                    }
                }
                return null;
            } else
                return "No hay información para mostrar";

        }

        public void PrintVehiculos()
        {
            Console.WriteLine(MostrarDatos());
            Console.WriteLine("=============================\n");
        }

        public static int Ordenar(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Precio > v2.Precio)
            {
                return -1;
            }
            else if (v1.Precio > v2.Precio)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void OrdenarPorPrecio()
        {
            this.listaVehiculos.Sort(Concesionaria.Ordenar);
        }

        public bool ValidarDatos()
        {
            if (this.listaVehiculos.Count <= 0 || this.listaVehiculos == null)
                return false;
            else
                return true;
        }

        public string MostrarOrdenado()
        {
            if (ValidarDatos())
            {
                Console.WriteLine("\n=============================\n");
                Console.WriteLine("Vehículos ordenados por precio de mayor a menor:");
                StringBuilder sb = new StringBuilder();
                foreach (var item in listaVehiculos)
                {
                    sb.AppendLine($"{item.Marca} {item.Modelo}");
                }
                return sb.ToString();
            }
            else
                return "No hay Información para mostrar";
           
        }

        public string MostrarDatos()
        {
            if (ValidarDatos())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in listaVehiculos)
                {
                    sb.Append("Marca: " + item.Marca);
                    sb.Append(" // Modelo: " + item.Modelo);
                    if (item is Moto)
                        sb.Append(" // Cilindrada: " + ((Moto)item).Cilindrada);
                    else
                        sb.Append(" // Puertas: " + ((Auto)item).Puertas);
                    sb.Append(" // Precio: " + item.Precio.ToString("C"));
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            else
                return "No hay Información para mostrar";

        }

    }
}
