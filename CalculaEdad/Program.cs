using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaEdad
{
    class Program
    {
        static void Main(string[] args)        
        {
            DateTime fechaNacimiento1 = new DateTime(1985, 11, 03);
            DateTime fechaNacimiento2 = new DateTime(1985, 11, 04);
            DateTime fechaNacimiento3 = new DateTime(1985, 11, 05);
            
            Console.WriteLine(calcularEdad(fechaNacimiento1));
            Console.WriteLine(calcularEdad(fechaNacimiento2));
            Console.WriteLine(calcularEdad(fechaNacimiento3));

            Console.ReadKey();
        }
        
        private static int cantidadBisiestos(DateTime fechaNacimiento)
        {
            int cantBisiestos = 0;
            DateTime now = DateTime.Now;

            for (int i = fechaNacimiento.Year; i <= DateTime.Now.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    cantBisiestos++;

                    if (fechaNacimiento.Year.Equals(i))
                        if (!(fechaNacimiento.Month <= 2))
                            cantBisiestos--;          
                }
            }

            return cantBisiestos;
        }

        private static int calcularEdad(DateTime fechaNacimiento)
        {            
            int cantDias = 0;
            float edad = 0;

            cantDias = (DateTime.Today - fechaNacimiento).Days;
            edad = (float)(cantDias - cantidadBisiestos(fechaNacimiento)) / 365;

            return (int)edad;
        }
    }
}
