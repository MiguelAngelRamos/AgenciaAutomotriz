using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz
{
    abstract class Vehiculo : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadMaxima { get; set; }
        public int NumeroDeRuedas { get; set; }

        /*
         En C# la palabra clave virtual se utiliza para indicar que un método puede ser anulado (override) en una clase derivada.
         */
        public virtual void Acelerar(int incremento) { 
           VelocidadMaxima = incremento + VelocidadMaxima; // explicito
                                                           // VelocidadMaxima += incremento; // implicito
            Console.WriteLine(Modelo + "ha acelerado, Nueva velocidad Máxima: " + VelocidadMaxima + "km/h");
            Console.WriteLine($"{Modelo} ha acelerado, Nueva velocidad Máxima: {VelocidadMaxima} km/h");
        }
        public virtual void MostrarDetalles() {
            Console.WriteLine($" Marca: {Marca}, Modelo: {Modelo}, Velocidad Máxima: {VelocidadMaxima} km/h, Número de Ruedas: {NumeroDeRuedas}");
        }
    }
}
