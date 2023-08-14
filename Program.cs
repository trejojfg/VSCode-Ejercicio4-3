using System;

namespace Ejercicio4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
            // Para ello existe la siguiente escala de precios:
            //              i5 (1)	    i7 (2)  	i9 (3)
            // 8 RAM (1)	USD 800	    USD 900	    USD 1200
            // 16 RAM (2)	USD 900	    USD 1000	USD 1400
            // 32 RAM (3)	USD 1000	USD 1400	USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB de información
            // y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo 
            // adicional de USD 300. Hacer un programa que solicite la opción de procesador, 
            // la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender o 0 para no extender)
            // y calcule y emita por pantalla el monto de la máquina seleccionada.
            
            int pc, ram, disco, precioVenta = 0;

            Console.WriteLine("Selecciona opcion del PC:");
            Console.WriteLine("- 1 si es i5");
            Console.WriteLine("- 2 si es i7");
            Console.WriteLine("- 3 si es i9");
            pc = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona opcion de la RAM:");
            Console.WriteLine("- 1 si es de 8");
            Console.WriteLine("- 2 si es de 16");
            Console.WriteLine("- 3 si es de 32");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona opcion de ampliar disco a 1TB:");
            Console.WriteLine("- 0 si NO se amplia");
            Console.WriteLine("- 1 si SI se amplia");
            disco = int.Parse(Console.ReadLine());
            
            switch (pc){
                case 1:
                    switch (ram)
                    {
                    case 1:
                        precioVenta = 800;
                        break;
                    case 2:
                        precioVenta = 900;
                        break;
                    case 3:
                        precioVenta = 1000;
                        break;
                    default:
                        break;
                    }
                    break;
                case 2:
                    switch (ram){
                        case 1:
                        precioVenta = 900;
                        break;
                        case 2:
                        precioVenta = 1000;
                        break;
                        case 3:
                        precioVenta = 1400;
                        break;
                        default:
                        break;
                    }
                    break;
                case 3:
                    switch (ram){
                        case 1:
                        precioVenta = 1200;
                        break;
                        case 2:
                        precioVenta = 1400;
                        break;
                        case 3:
                        precioVenta = 2000;
                        break;
                        default:
                        break;
                    }
                    break;
                default:
                break;
            }
            if (disco == 1)
                precioVenta += 300;

            Console.WriteLine("El precio total a pagar es: " + precioVenta);
            Console.WriteLine("Fin del programa");
        }
    }
}
