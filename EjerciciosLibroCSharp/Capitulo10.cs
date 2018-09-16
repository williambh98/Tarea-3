using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo10
    {
        public void Menu2()
        {
            Ejercicio1 cap10 = new Ejercicio1();
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del cap#10");
            Console.WriteLine("\n1.Ejercicio1" +
                              "\n2.Ejercicio2" +
                              "\n3.Ejercicio3" +
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
        }
        class Ejercicio1//Crear el diseño de una clase para llevar el inventario de una tienda.
        {
            private int ID { get; set; }
            private string nombre { get; set; }
            private double precio { get; set; }
            private double costo { get; set; }
            private double cantidad { get; set; }



            public Ejercicio1()
            {
                ID = 0;
                precio = 0;
                costo = 0;
                cantidad = 0;
            }
            public Ejercicio1(int id, string nombre, double costo, double precio, double cantidad)
            {
                this.ID = id;
                this.nombre = nombre;
                this.costo = costo;
                this.precio = precio;
                this.cantidad = cantidad;
            }



        }

        class Ejercicio2//Crear una clase para llevar lainformación de los estudiantes de una escuela.
        {
            private int id { get; set; }
            private string nombre { get; set; }
            private string apellidos { get; set; }
            private string matricula { get; set; }
            private string cedula { get; set; }
            private string direccion { get; set; }
            private string carrera { get; set; }
            private string tetlefono { get; set; }

            public Ejercicio2()
            {
                id = 0;
            }
            public Ejercicio2(int id, string nombre, string apellidos, string matricula, string cedula, string direccion, string carrera, string telefono)
            {
                this.id = id;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.matricula = matricula;
                this.cedula = cedula;
                this.direccion = direccion;
                this.carrera = carrera;
                this.tetlefono = tetlefono;


            }

        }
        public class Ejercicio3//Crear una clase para polígonos con sobrecarga del constructor.
        {
            private float lado;
            private float altura;
            private float base1;

            public Ejercicio3(float lado)
            {
                this.lado = lado;
                altura = 0;
                base1 = 0;
            }
            public Ejercicio3(float base1, float altura)
            {
                lado = 0;
                this.base1 = base1;
                this.altura = altura;

            }
            public float Lado
            {
                get
                {
                    return lado;
                }
                set
                {
                    if (value <= 0)
                        lado = 1;
                    else
                        lado = value;
                }
            }
            public float Altura
            {
                get
                {
                    return altura;
                }
                set
                {
                    if (value <= 0)
                        altura = 1;
                }


            }
            private float Base1
            {
                get
                {
                    return base1;
                }
                set
                {
                    if (value <= 0)
                        base1 = 1;
                }
            }
        }
    }
}
