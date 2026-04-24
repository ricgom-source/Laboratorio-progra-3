using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_progra_3
{
    internal class Program
    {
        class Prestamo

        {
            private string codigo;
            private string nombre;
            private int carnet;
            private string carrera;
            private string equipo;
            private int cantidad;
            private string estado;

            public string Codigo

            {
                get

                {
                    return codigo;

                }

                set

                {

                    if(value.Length<=5)

                    {

                        Console.WriteLine("El código debe tener almenos 6 carácteres");

                    }

                    else
                    {

                        Console.WriteLine("Código valido");

                    }

                }


            }

            public string Nombre

            {
                get

                {
                    return nombre;

                }

                set

                {
                    if(value.Length<3)

                    {
                        Console.WriteLine("El nombre debe tener almenos 3 carácteres");


                    }

                }



            }







        }
            



        static void Main(string[] args)
        {
        }
    }
}
