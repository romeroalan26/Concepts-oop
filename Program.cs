using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_primer_programa_en_consola
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //BIENVENIDA AL PROGRAMA
            {  //Constantes n nombre, ap apellido, dt datetime
            string n = "Alan";
            string ap = "Romero";
            DateTime dt = new DateTime(2022, 2, 2, 17, 26, 0);

            //Variables ndu nombre de usuario,adu apellido de usuario, nc nombre completo
            var ndu = "";
            var adu = "";

            //Instrucciones
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); 
            Console.WriteLine("Programa en Consola de la Materia OOP Creado por {0} {1}", n, ap);
            Console.WriteLine(dt);
            Console.WriteLine("Introduzca Nombre de Usuario:");
            ndu = Console.ReadLine();
            Console.WriteLine("Indroduzca Apellido de usuario:");
            adu = Console.ReadLine();

            Console.WriteLine("Bienvenido/a {0} {1}", ndu, adu);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            }







            //MENU 
            {

                Console.WriteLine("MENU PRINCIPAL.\n");
                Console.WriteLine("1 - Opcion Calculadora.");
                Console.WriteLine("2 - Creacion de Archivos.");
                Console.WriteLine("3 - Personal.\n");

                string input = Console.ReadLine();

                //SUB MENU  
                switch (input)

                {
                    case "1":
                        Console.WriteLine("¿Qué desea calcular?\n");
                        Console.WriteLine("1  - Calculador de Distancia.");
                        Console.WriteLine("2  - Calculador de Promedio.");
                        Console.WriteLine("3  - Contador de Billetes.");
                        Console.WriteLine("4  - Suma.");
                        Console.WriteLine("5  - Resta.");
                        Console.WriteLine("6  - Muliplicacion.");
                        Console.WriteLine("7  - Division.");
                        Console.WriteLine("8  - Porcentaje.");
                        Console.WriteLine("9  - Factorial.");
                        Console.WriteLine("10 - Promedio.");
                        Console.WriteLine("11 - Raiz cuadrada.");
                        Console.WriteLine("12 - Derivada.\n");

                        string input1 = Console.ReadLine();
                        switch (input1)
                        {
                            case "1":
                                ////CALCULADOR DE DISTANCIA
                                {
                                    Console.WriteLine("Seleccionó Calculador de Distancia.\n");


                                    //Variables
                                    float t, v;
                                    string tiempo, velocidad;
                                    float d;

                                    Console.WriteLine("Calculadora de Distancia en Movimiento Rectilineo Uniforme (MRU)\n");
                                    Console.WriteLine("Introduzca el valor del Tiempo (sg):");
                                    tiempo = Console.ReadLine();
                                    t = float.Parse(tiempo);
                                    Console.WriteLine("Introduzca el valor de la Velocidad (m/s)");
                                    velocidad = Console.ReadLine();
                                    v = float.Parse(velocidad);
                                    d = v * t;
                                    Console.WriteLine("La distancia es igual a {0}m\n", d);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;

                                }

                            case "2":
                                //CALCULADOR DE 3 CALIFICACIONES
                                {
                                    Console.WriteLine("Seleccionó Calculador de Promedio.\n");


                                    //Variables n1 nota 1, n2 nota 2, n3 nota 3, 
                                    float n1, n2, n3, pr;
                                    string nota1, nota2, nota3;
                                    Console.WriteLine("Calculadora de promedio.\n");
                                    Console.WriteLine("Introducir primera nota parcial:");
                                    nota1 = Console.ReadLine();
                                    n1 = float.Parse(nota1);
                                    Console.WriteLine("Introducir segunda nota parcial:");
                                    nota2 = Console.ReadLine();
                                    n2 = float.Parse(nota2);
                                    Console.WriteLine("Introducir tercera nota parcial:");
                                    nota3 = Console.ReadLine();
                                    n3 = float.Parse(nota3);
                                    pr = (n1 + n2 + n3) / 3;
                                    Console.WriteLine("Su promedio es de {0}.\n", pr);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }

                            case "3":
                                //CONTADOR DE BILLETES
                                {
                                    Console.WriteLine("Seleccionó Contador de Billetes.\n");

                                    //Variables
                                    int amount,a1 = 0, a5 = 0, a10 = 0, a25 = 0, a50 = 0, a100 = 0, a200 = 0, a500 = 0, a1000 = 0, a2000 = 0;
                                    Console.WriteLine("Ingrese una cantidad");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount >= 2000)
                                    {
                                        a2000 = (amount / 2000);
                                        amount = amount - (a2000 * 2000);
                                    }
                                    if (amount >= 1000)
                                    {
                                        a1000 = (amount / 1000);
                                        amount = amount - (a1000 * 1000);
                                    }
                                    if (amount >= 500)
                                    {
                                        a500 = (amount / 500);
                                        amount = amount - (a500 * 500);
                                    }
                                    if (amount >= 200)
                                    {
                                        a200 = (amount / 200);
                                        amount = amount - (a200 * 200);
                                    }
                                    if (amount >= 100)
                                    {
                                        a100 = (amount / 100);
                                        amount = amount - (a100 * 100);
                                    }
                                    if (amount >= 50)
                                    {
                                        a50 = (amount / 50);
                                        amount = amount - (a50 * 50);
                                    }
                                    if (amount >= 25)
                                    {
                                        a25 = (amount / 25);
                                        amount = amount - (a25 * 25);
                                    }
                                    if (amount >= 10)
                                    {
                                        a10 = (amount / 10);
                                        amount = amount - (a10 * 10);
                                    }
                                    if (amount >= 5)
                                    {
                                        a5 = (amount / 5);
                                        amount = amount - (a5 * 5);
                                    }
                                    if (amount >= 1)
                                    {
                                        a1 = (amount / 1);
                                        amount = amount - (a1 * 1);
                                    }

                                    Console.WriteLine("Billetes de 2000:" + a2000);
                                    Console.WriteLine("Billetes de 1000:" + a1000);
                                    Console.WriteLine("Billetes de 500:" + a500);
                                    Console.WriteLine("Billetes de 200:" + a200);
                                    Console.WriteLine("Billetes de 100:" + a100);
                                    Console.WriteLine("Billetes de 50:" + a50);
                                    Console.WriteLine("Billetes de 25:" + a25);
                                    Console.WriteLine("Billetes de 10:" + a10);
                                    Console.WriteLine("Billetes de 05:" + a5);
                                    Console.WriteLine("Billetes de 01:" + a1);

                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }

                            case "4":
                                //SUMA
                                {
                                    Console.WriteLine("Seleccionó Suma.\n");
                                    //VARIABLES
                                    float n1, n2, res;
                                    string val1, val2;
                                    Console.WriteLine("Introduzca Primer Valor:");
                                    val1 = Console.ReadLine();
                                    n1 = float.Parse(val1);
                                    Console.WriteLine("Introduzca Segundo Valor:");
                                    val2 = Console.ReadLine();
                                    n2 = float.Parse(val2);
                                    res = n1 + n2;
                                    Console.WriteLine("El resultado es:\n" + res);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();
                                }

                                break;

                            case "5":
                                //RESTA
                                {
                                    Console.WriteLine("Seleccionó Resta.\n");
                                    //VARIABLES
                                    float n1, n2, res;
                                    string val1, val2;
                                    Console.WriteLine("Introduzca Primer Valor:");
                                    val1 = Console.ReadLine();
                                    n1 = float.Parse(val1);
                                    Console.WriteLine("Introduzca Segundo Valor:");
                                    val2 = Console.ReadLine();
                                    n2 = float.Parse(val2);
                                    res = n1 - n2;
                                    Console.WriteLine("El resultado es:\n" + res);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }



                            case "6":
                                //MULTIPLICACION
                                {
                                    Console.WriteLine("Seleccionó Multiplicación.\n");
                                    //VARIABLES
                                    float n1, n2, res;
                                    string val1, val2;
                                    Console.WriteLine("Introduzca Primer Valor:");
                                    val1 = Console.ReadLine();
                                    n1 = float.Parse(val1);
                                    Console.WriteLine("Introduzca Segundo Valor:");
                                    val2 = Console.ReadLine();
                                    n2 = float.Parse(val2);
                                    res = n1 * n2;
                                    Console.WriteLine("El resultado es:\n" + res);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }



                            case "7":
                                //DIVISION
                                {
                                    Console.WriteLine("Seleccionó División.\n");
                                    //VARIABLES
                                    float n1, n2, res;
                                    string val1, val2;
                                    Console.WriteLine("Introduzca Primer Valor:");
                                    val1 = Console.ReadLine();
                                    n1 = float.Parse(val1);
                                    Console.WriteLine("Introduzca Segundo Valor:");
                                    val2 = Console.ReadLine();
                                    n2 = float.Parse(val2);
                                    res = n1 / n2;
                                    Console.WriteLine("El resultado es:\n" + res);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }

                            case "8":
                                //PORCENTAJE
                                {
                                    Console.WriteLine("Seleccionó Porcentaje\n");
                                    //VARIABLES
                                    float n1, n2, res;
                                    string valor1, valor2;
                                    Console.WriteLine("Introduzva valor 1:");
                                    valor1 = Console.ReadLine();
                                    n1 = float.Parse(valor1);
                                    Console.WriteLine("Introduzva valor 2:");
                                    valor2 = Console.ReadLine();
                                    n2 = float.Parse(valor2);
                                    res = (n1 / n2) * 100;
                                    Console.WriteLine("El resultado es de: {0}%.\n", res);

                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }




                            case "9":
                                //FACTORIAL
                                {
                                    Console.WriteLine("Seleccionó Factorial.\n");
                                    int f = 1, a, n;
                                    string b;
                                    a = 1;
                                    Console.Write("Ingrese un numero entero: ");
                                    b = Console.ReadLine();
                                    n = int.Parse(b);
                                    while (a <= n)
                                    {
                                        f = f * a;
                                        a = a + 1;
                                    }
                                    Console.WriteLine("El Resultado es:\n " + f);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }



                            case "10":
                                //PROMEDIO DE 10 VALORES
                                {
                                    Console.WriteLine("Seleccionó Promedio.\n");
                                    //Variables
                                    float n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, pr;
                                    string valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8, valor9, valor10;
                                    Console.WriteLine("Calculadora de promedio de 10 valores.\n");
                                    Console.WriteLine("Introducir valor 1:");
                                    valor1 = Console.ReadLine();
                                    n1 = float.Parse(valor1);
                                    Console.WriteLine("Introducir valor 2:");
                                    valor2 = Console.ReadLine();
                                    n2 = float.Parse(valor2);
                                    Console.WriteLine("Introducir valor 3:");
                                    valor3 = Console.ReadLine();
                                    n3 = float.Parse(valor3);
                                    Console.WriteLine("Introducir valor 4:");
                                    valor4 = Console.ReadLine();
                                    n4 = float.Parse(valor4);
                                    Console.WriteLine("Introducir valor 5:");
                                    valor5 = Console.ReadLine();
                                    n5 = float.Parse(valor5);
                                    Console.WriteLine("Introducir valor 6:");
                                    valor6 = Console.ReadLine();
                                    n6 = float.Parse(valor6);
                                    Console.WriteLine("Introducir valor 7:");
                                    valor7 = Console.ReadLine();
                                    n7 = float.Parse(valor7);
                                    Console.WriteLine("Introducir valor 8:");
                                    valor8 = Console.ReadLine();
                                    n8 = float.Parse(valor8);
                                    Console.WriteLine("Introducir valor 9:");
                                    valor9 = Console.ReadLine();
                                    n9 = float.Parse(valor9);
                                    Console.WriteLine("Introducir valor 10:");
                                    valor10 = Console.ReadLine();
                                    n10 = float.Parse(valor10);
                                    pr = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 3;
                                    Console.WriteLine("Su promedio es de {0}.\n", pr);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }

                            case "11":
                                //RAIZ
                                {
                                    Console.WriteLine("Seleccionó Raiz Cuadrada.\n");
                                    //Variables
                                    int n = 0;
                                    Console.WriteLine("Intruduzca el valor:");
                                    n = int.Parse(Console.ReadLine());
                                    double res = Math.Sqrt(n);
                                    Console.WriteLine("El resultado es:\n" + res);
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }



                            case "12":
                                //DERIVADA
                                {
                                    Console.WriteLine("Seleccionó Derivada.\n");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("¡GRACIAS!");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("Precione cualquier tecla para cerrar el programa...");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.ReadKey();

                                    break;
                                }

                            default:

                                break;


                        }

                        break;

                        case "2":
                        Console.WriteLine("Selecciono Creacion de Archivos.\n");
                        Console.WriteLine("1 - Crear un Archivo.");
                        Console.WriteLine("2 - Crear Folder.");

                        string input2 = Console.ReadLine();
                        switch (input2)
                        { case "1":
                                { Console.WriteLine("Seleccionó crear un Archivo.\n");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey();

                                    break;
                                }

                                

                            case "2":
                                { Console.WriteLine("Seleccionó Crear Folder.\n");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey();

                                    break;
                                }
                            default:
                                {
                                    
                                    break;
                                }
                        }



                        break; 

                    case "3":
                        Console.WriteLine("Seleccionó Personal.\n");
                        Console.WriteLine("1 - Insertar Persona.");
                        Console.WriteLine("2 - Insertar Empleado.");
                        Console.WriteLine("3 - Insertar Departamento.");
                        Console.WriteLine("4 - Ver Empleado.");

                        string input3 = Console.ReadLine(); 
                        switch (input3) { case "1":
                                {
                                    Console.WriteLine("Seleccionó Insertar Persona.");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey();
                                    break;
                                }

                            case "2":
                                {
                                    Console.WriteLine("Seleccionó Insertar Empleado.");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey(); 
                                    break; }
                            case "3":
                                {
                                    Console.WriteLine("Seleccionó Insertar Departamento.");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("Seleccionó Ver Empleado.");
                                    Console.WriteLine("Disculpe. Por el momento, esta opcion no está disponible.");
                                    Console.WriteLine("Presione culquier tecla para salir del programa...");
                                    Console.ReadKey();
                                    break;
                                }
                            default:

                                break;
                        }
                    

                        break;

                        default:

                        break;

                }
            }






        }
        
    }
}
