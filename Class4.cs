using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrep2
{
    class Alquiler
    {
        int nit;
        string placa;
        int kilometrosRecorridos;
        DateTime fechaDevolucion;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public int KilometrosRecorridos { get => kilometrosRecorridos; set => kilometrosRecorridos = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
    }
}
