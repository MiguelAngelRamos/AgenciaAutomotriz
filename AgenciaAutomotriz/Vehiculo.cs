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

        public void Acelerar(int incremento) { 
           VelocidadMaxima = incremento + VelocidadMaxima; // explicito
                                                           // VelocidadMaxima += incremento; // implicito
            // Console.WriteLine(Modelo + "ha acelerado, Nueva velocidad Máxima: " + VelocidadMaxima + "km/h");
            Console.WriteLine($"{Modelo} ha acelerado, Nueva velocidad Máxima: {VelocidadMaxima} km/h");
        }
        public void MostrarDetalles() {
            Console.WriteLine($" Marca: {Marca}, Modelo: {Modelo}, Velocidad Máxima: {VelocidadMaxima} km/h, Número de Ruedas: {NumeroDeRuedas}");
        }
    }
}
