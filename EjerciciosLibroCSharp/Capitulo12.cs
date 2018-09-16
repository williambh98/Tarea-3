using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo12
    {
        public void Menu3()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del cap#12");
            Console.WriteLine("\n1.Ejercicio1" +
                              "\n2.Ejercicio3" +
                              "\n3.Ejercicio4" +
                              "\n4.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();

                    Console.Clear();
                    Me.Menu();
                    break;
                case 2:
                    {
                        Console.Clear();

                        Console.Clear();
                        Me.Menu();
                        break;
                    }
                case 3:
                    Console.Clear();

                    Me.Menu();
                    break;
                case 4:
                    Me.Menu();
                    break;

            }
            Console.ReadKey();

        }

        public void Ejercicio()
        {
            Console.WriteLine("William Burgos Hernandez");
            Console.ReadKey();
        }

       

    }
}
