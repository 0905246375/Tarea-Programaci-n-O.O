using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion_O._Objetos.Mis_clases
{
    internal class Motocicleta : Vehiculo
    {
        private int Rapidez;
        private bool encendido;
        private int CargaDeCombustion; 
        public Motocicleta (int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            Rapidez = 90; 
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Rapidez++; 
        }


        public int NivelDeRapidez() { return Rapidez; }
        public void RapidezTotal()
        {
            Rapidez++;
        }
        public override void Encender()
        {
            encendido = true;

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

    }
} 
