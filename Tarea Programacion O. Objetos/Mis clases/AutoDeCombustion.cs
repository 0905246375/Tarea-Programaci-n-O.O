using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion_O._Objetos.Mis_clases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private  int Gasolina; 
        public int CapacidadDeTanque { get; set; }
        public int CosumoKilometro { get; }

        public bool EnMarcha { get; set; }
        private bool encendido;
        private int CargaDeCombustion;
        private int frenar;

        public AutoDeCombustion(int anio, string elColor, string elModelo, int CapacidadDeTanque, int ConsumoKilometro, bool EnMarcha) : base(anio, elColor, elModelo)
        {
            Gasolina = 60; 
            CapacidadDeTanque = CapacidadDeTanque;
            CosumoKilometro = ConsumoKilometro;
            EnMarcha = false;
            frenar = 10; 
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Gasolina++;
        }
        public int NivelGasolina() { return Gasolina; }
        public void Gasolinar()
        {
            Gasolina++;
        }
        public override void Encender()
        {
            encendido = true;

        }
        //Frenar 
        public override void Frenar(int cuanto)
        {
            frenar++; 

        }
        public int FrenarVehiculo() { return frenar; }
        public void Frenara()
        {
            Gasolina -= frenar; 
        }

        public bool EncenderAuto() { return encendido; }
        public void encendidor()
        {
            encendido = true;
        }
        public override void Apagar()
        {
            encendido = false;

        }
        public bool ApagarAuto() { return encendido; }

        public void apaga()
        {
            encendido = false;
            velocidad = 0;
        }
        public override void CargarCombustible(int cantidad)
        {
            CargaDeCombustion += 50;

        }
        public int CargaCombustible() { return CargaDeCombustion; }
        public void Combustible()
        {
            if (CargaDeCombustion > 100) CargaDeCombustion = 100;

        }
        public AutoDeCombustion(int anio, string elColor, string elModelo, string v1, string v2, string v3) : base(anio, elColor, elModelo)
        {
        }
    }
}
// falta agregar un paso 