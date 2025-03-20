
using Tarea_Programacion_O._Objetos.Mis_clases;

Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN" );

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

AutoDeCombustion Nuevo = new AutoDeCombustion(2026, "Rosado", "Toyota", "10", "40", "False");

Motocicleta  Agregada = new Motocicleta(2025, "Negra", "Navi");

Camion ElMasPesado = new Camion(2024, "Rojo", "Toyota");

Console.WriteLine("Vehiculo"); 
Console.WriteLine("CarrO Electrico");
miBYD.InformacionVehiculo(); 
miBYD.cargarBateria();
miBYD.Frenara();
miBYD.encendidor();
miBYD.apaga();
miBYD.Combustible();
Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria()); 
Console.WriteLine("La velodidad del carro disminuyo al frenara {0}", miBYD.FrenarVehiculo());   
Console.WriteLine("El carro esta encendido: {0} ", miBYD.EncenderAuto());
Console.WriteLine("El carro esta apagado: {0}", miBYD.ApagarAuto());
Console.WriteLine("Combustible cargado. Nivel de combustible: {0}%", miBYD.CargaCombustible());

Console.WriteLine("Auto de Combustion");
Nuevo.InformacionVehiculo();
Nuevo.Gasolinar();
Nuevo.encendidor(); 
Nuevo.apaga();
Nuevo.Combustible();
Nuevo.Frenara();
Console.WriteLine("El nivel de la Gasolina: {0}", Nuevo.NivelGasolina());
Console.WriteLine("El carro esta encendido: {0} ", Nuevo.EncenderAuto());
Console.WriteLine("El carro esta apagado: {0}", Nuevo.ApagarAuto());
Console.WriteLine("Combustible cargado. Nivel de combustible: {0}%", Nuevo.CargaCombustible());
Console.WriteLine("La velodidad del auto disminuyo al frenar {0}", Nuevo.FrenarVehiculo()); 

Console.WriteLine("Motocicleta");
Agregada.InformacionVehiculo();
Agregada.RapidezTotal();
Agregada.encendidor();
Agregada.apaga();
Agregada.CargaCombustible();
Console.WriteLine("La rapidez total de la motocicleta es: {0}", Agregada.NivelDeRapidez());
Console.WriteLine("La motocicleta esta encendida: {0} ", Agregada.EncenderAuto());
Console.WriteLine("La motocicleta esta apagada: {0}", Agregada.ApagarAuto());
Console.WriteLine("Combustible cargado. Nivel de combustible: {0}%", Agregada.CargaCombustible());

Console.WriteLine("Camion");
ElMasPesado.InformacionVehiculo();
ElMasPesado.DiselTotal();
ElMasPesado.encendidor();
ElMasPesado.apaga();
ElMasPesado.Combustible();
Console.WriteLine( " La Carga de Diesel del camion es: {0}", ElMasPesado.NivelDeCargaDeDisel());
Console.WriteLine("El camion  esta encendido: {0} ", ElMasPesado.EncenderAuto());
Console.WriteLine("El camion esta apagado: {0}", ElMasPesado.ApagarAuto());
Console.WriteLine("Combustible cargado. Nivel de combustible: {0}%", ElMasPesado.CargaCombustible());
