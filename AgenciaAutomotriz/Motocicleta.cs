using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz
{
    class Motocicleta: Vehiculo
    {
        public bool TieneSidecar { get; set; }
        public Motocicleta()
        {
            NumeroDeRuedas = 2;
        }

        public override void MostrarDetalles() 
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tiene Sidecar: {TieneSidecar}");
           // Console.WriteLine($" Marca: {Marca}, Modelo: {Modelo}, Velocidad Máxima: {VelocidadMaxima} km/h, Número de Ruedas: {NumeroDeRuedas}, Tiene Sidecar: {TieneSidecar}");
        }
    }
}
