using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion_O._Objetos.Mis_clases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private bool encendendido;
        public  int velocidad = 0;
        private bool encendido;
        private int CargaDeCombustion; 

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.encendendido = true;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public  virtual void Frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("Vas a {0} KMS / Hora después de frenar", velocidad);
        }
        public  virtual void Encender()
        {
            encendido = true;
            
        }
        public  virtual void Apagar()
        {
            encendido = false;
            velocidad = 0; 
          
        }
        public  virtual void CargarCombustible(int cantidad)
        {
            CargaDeCombustion += cantidad;
            if (CargaDeCombustion > 100) CargaDeCombustion = 100; 
        }
    }
}

