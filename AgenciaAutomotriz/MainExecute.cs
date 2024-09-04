using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz
{
    class MainExecute
    {
        static void Main(string[] args) { 
            // Primer auto
            Auto auto = new Auto();
            auto.Marca = "Toyota";
            auto.Modelo = "Corolla";
            auto.VelocidadMaxima = 180;

            // Segundo auto
            Auto auto2 = new Auto();
            auto2.Marca = "Ford";
            auto2.Modelo = "Fiesta";
            auto2.VelocidadMaxima = 200;

            // Moticicleta
            Motocicleta moto = new Motocicleta();
            moto.Marca = "Harley Davidson";
            moto.Modelo = "Iron 883";
            moto.VelocidadMaxima = 120;
            moto.TieneSidecar = false;

            Motocicleta moto2 = new Motocicleta()
            {
                Marca = "BMW",
                Modelo = "R 1250 GS",
                VelocidadMaxima = 200,
                TieneSidecar = true
            };

            // Mostrar los detalles
            auto.MostrarDetalles();
            auto2.MostrarDetalles();

            moto.MostrarDetalles();
            moto2.MostrarDetalles();

        }
    }
}
