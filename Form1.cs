using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labrep2
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Reporte> reportes = new List<Reporte>();
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportes.Clear();
            foreach(var alquiler in alquileres)
            {
                Cliente cliente = clientes.Find(c=> c.Nit == alquiler.Nit);
                Vehiculo vehiculo = vehiculos.Find(v => v.Placa == alquiler.Placa);
                Reporte reporte= new Reporte();

                reporte.Nombre = cliente.Nombre;
                reporte.Marca = vehiculo.Marca;
                reporte.Modelo = vehiculo.Modelo;
                reporte.FechaDevuelto = alquiler.FechaDevolucion;
                reporte.TotalPagar = vehiculo.Kilometraje = alquiler.KilometrosRecorridos;

                reportes.Add(reporte);

            }

        }
        private void GrabarVehiculos()
        {
            FileStream flujo = new FileStream("Vehiculo.txt", FileMode.Open, FileAccess.Write.);
            StreamWriter writer = new StreamWriter(flujo);
            foreach(var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.Precio);
            }

            writer.Close();

         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.Placa = textBox1.Text;
            vehiculo.Marca = textBox2.Text;
            vehiculo.Modelo = textBox3.Text;
            vehiculo.Color = textBox4.Text;
            vehiculo.Precio = Convert.ToDecimal(textBox5.Text);



        }
    }
}
