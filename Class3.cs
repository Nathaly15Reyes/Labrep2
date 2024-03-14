using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrep2
{
    class Vehiculo
    {
        string marca;
        string placa;
        string color;
        string modelo;
        int kilometraje;
        decimal precio;

        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Color { get => color; set => color = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
    }
}
