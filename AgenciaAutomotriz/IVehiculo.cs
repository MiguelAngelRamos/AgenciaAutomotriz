using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz
{
    internal interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        int VelocidadMaxima { get; set; }

        void MostrarDetalles();
        void Acelerar(int incremento);
    }
}
