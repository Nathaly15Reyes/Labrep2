using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrep2
{
    class Reporte
    {
        string nombre;
        string marca;
        string modelo;
        DateTime fechaDevuelto;
        int totalPagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public DateTime FechaDevuelto { get => FechaDevuelto; set => FechaDevuelto = value; }
        public int TotalPagar { get => totalPagar; set => totalPagar = value; }
    }
}
