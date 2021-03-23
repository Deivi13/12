using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicando_csharp
{
    class Empleados
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        double Salario { get; set; }
        static Empleados[] empleados;

        public static void Cargar()
        {
            empleados = new Empleados[5];

            for (int i = 0; i < empleados.Length; i++)
            {
                try
                {
                    empleados[i] = new Empleados();
                    Console.Write("Ingresa el empleado #{0} Nombre => ", i + 1);
                    empleados[i].Nombre = Console.ReadLine();
                    Console.Write("Ingresa el empleado #{0} Edad => ", i + 1);
                    empleados[i].Edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el empleado #{0} Salario => ", i + 1);
                    empleados[i].Salario = double.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {

                    throw new Exception("Recuerda Nombre es un texto, Edad y Salario son valores Numericos 🙂");
                }
            }
        }

        public static void SalarioMayor()
        {

            if (empleados != null)
            {
                double max = empleados[0].Salario;
                string Empleado_Nombre = empleados[0].Nombre;

                for (int i = 1; i < empleados.Length; i++)
                {
                    if (empleados[i].Salario > max)
                    {
                        max = empleados[i].Salario;
                        Empleado_Nombre = empleados[i].Nombre;
                    }
                }

                Console.WriteLine("El empelado con el salario mayor es {0} => ", Empleado_Nombre);
                Console.WriteLine("Tiene un Salario de ${0}", max);
            }
            else
            {
                throw new Exception("Debes primero cargar los usuarios para saber el salario 🙂 ");
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Empleados.Cargar();

            Empleados.SalarioMayor();

        }
    }
}
