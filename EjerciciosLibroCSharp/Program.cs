using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program me = new Program();
            me.Menu();
        }
        public void Menu()
        {
            Capitulo9 Cap9 = new Capitulo9();
            int op = 0;
            //Menu

            Console.WriteLine("Eliga una opcion para ver lo ejercicio del capitulo \n" +
                "\n1.Capitulo9" +
                "\n2.Capitulo10" +
                "\n3.Capitulo12" +
                "\n4.Salir\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Cap9.Menu1();
                    break;

                case 2:
            
                    break;

                case 3:
                ;
                    break;
                case 4:
            

                    break;
                case 5:
                    Console.WriteLine("Opcion salir\n" +
                        "Preciones Cual Quier tecla para salir");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;


            }

            Console.ReadKey();


        }
    }
}

