using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz
{
    class Camion: Vehiculo
    {
        public int CapacidadDeCarga { get; set; }

        public Camion()
        {
            NumeroDeRuedas = 6;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Capacidad de Carga: {CapacidadDeCarga} Kg");
            // Console.WriteLine($" Marca: {Marca}, Modelo: {Modelo}, Velocidad Máxima: {VelocidadMaxima} km/h, Número de Ruedas: {NumeroDeRuedas}, Capacidad de Carga: {CapacidadDeCarga}");
        }
    }
}
