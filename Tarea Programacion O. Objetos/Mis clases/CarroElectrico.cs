using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion_O._Objetos.Mis_clases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        private int frenar;
        private bool encendido;
        private int frenara;
        private int velodidad;
        private int CargaDeCombustion; 

        public CarroElectrico(int anio, string elColor, string elModelo ) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50;
            frenar = 10; 
            velocidad = 5;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }
        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }
        public  override void  Frenar(int cuanto)
        {
            frenar --; 
               
        }
        public int FrenarVehiculo () { return frenar; }
        public void Frenara()
        {
            cargaBateria -= frenar; 
        }
     

        public override void Encender()
        {
            encendido=true;

        }
        public bool EncenderAuto () { return encendido; }   
        public void encendidor()
        {
            encendido = true;
        }
        public override void Apagar()
        {
            encendido = false;
            
        }
        public bool ApagarAuto () { return encendido; }

        public void apaga ()
        {
            encendido = false ;
            velocidad = 0;  
        }
        public override void CargarCombustible(int cantidad)
        {
            CargaDeCombustion += 50;

        }
        public int CargaCombustible() { return CargaDeCombustion; }
        public void Combustible ()
        {
            if (CargaDeCombustion > 100) CargaDeCombustion = 100; 
           
        }
        // terminado 
    }
}

