using System;

namespace LAB_SEMANA14
{
    class Program
    {



        static void Main(string[] args)
        {
            string opcion;
            int[] anio;
            int prom = 0;



            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  Mayor de edad y promedio ");
            Console.WriteLine("Presione 2: ------>  Notas escolares");
            Console.WriteLine("Presione 3: ------>  Salir");

            opcion = Console.ReadLine();

            string[] nom = new string[5];
            string[] apellido = new string[5];
            anio = new int[5];




            ;


            switch (opcion)
            {
                case "1":



                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Nombre de la persona : ");
                        nom[f] = Console.ReadLine();


                        Console.WriteLine("Ingrese su edad:  ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);

                        prom = prom + anio[f];
                    }
                    Console.WriteLine("");


                    Console.WriteLine("los mayores de edad son");
                    for (int f = 0; f < 5; f++)
                    {

                        if (anio[f] >= 18)
                        {


                            Console.WriteLine(nom[f] + " y tiene : " + anio[f]);


                        }

                    }
                    Console.WriteLine("");

                    for (int f = 0; f < 1; f++)
                    {

                        Console.WriteLine("El promedio de todas las edades es de :" + prom / 5);

                    }


                    break;












                case "2":




                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Nombre de la persona : ");
                        nom[f] = Console.ReadLine();


                        Console.WriteLine(" ");
                        Console.WriteLine("Nombre de la apellido : ");
                        apellido[f] = Console.ReadLine();
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese su nota:  ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);
                        prom = prom + anio[f];
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    if (anio[0] > anio[1] && anio[0] > anio[2] && anio[0] > anio[3] && anio[0] > anio[4])
                    {
                        Console.WriteLine("El primer niño ingresado es de la nota mas alta . ");
                    }

                    if (anio[1] > anio[0] && anio[1] > anio[2] && anio[1] > anio[3] && anio[1] > anio[4])
                    {
                        Console.WriteLine("El segundo niño ingresado es de la nota mas alta ");
                    }

                    if (anio[2] > anio[0] && anio[2] > anio[1] && anio[2] > anio[3] && anio[2] > anio[4])
                    {
                        Console.WriteLine("El tercero niño ingresado es de la nota mas alta.");
                    }

                    if (anio[3] > anio[0] && anio[3] > anio[1] && anio[3] > anio[2] && anio[3] > anio[4])
                    {
                        Console.WriteLine("El cuarto niño ingresado es de la nota mas alta");
                    }

                    if (anio[4] > anio[0] && anio[4] > anio[1] && anio[4] > anio[2] && anio[4] > anio[3])
                    {
                        Console.WriteLine("El quinto niño ingresado es de la nota mas alta.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("y eL niño con la nota mas baja es   ");


                    if (anio[0] < anio[1] && anio[0] < anio[2] && anio[0] < anio[3] && anio[0] < anio[4])
                    {
                        Console.WriteLine("el primero. ");
                    }

                    if (anio[1] < anio[0] && anio[1] < anio[2] && anio[1] < anio[3] && anio[1] < anio[4])
                    {
                        Console.WriteLine("el segundo  ");
                    }

                    if (anio[2] < anio[0] && anio[2] < anio[1] && anio[2] < anio[3] && anio[2] < anio[4])
                    {
                        Console.WriteLine("El tercero ");
                    }

                    if (anio[3] < anio[0] && anio[3] < anio[1] && anio[3] < anio[2] && anio[3] < anio[4])
                    {
                        Console.WriteLine("el cuarto ");
                    }

                    if (anio[4] < anio[0] && anio[4] < anio[1] && anio[4] < anio[2] && anio[4] < anio[3])
                    {
                        Console.WriteLine("el quinto");
                    }



                    Console.WriteLine(" ");
                    for (int f = 0; f < 1; f++)
                    {

                        Console.WriteLine("El promedio de las notas es de :" + prom / 5);

                    }


                    Console.WriteLine(" ");
                    Console.WriteLine("los estudiantes aprobados son: ");
                    Console.WriteLine(" ");
                    for (int f = 0; f < 5; f++)
                    {

                        if (anio[f] >= 71)
                        {


                            Console.WriteLine(nom[f] + " " + apellido[f] + " y tiene : " + anio[f]);


                        }

                    }

                    break;



                case "3":
                    Console.WriteLine("Gracias por ingresar");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("No seleccionó ninguna de las opciones disponibles ");
                    break;

            }



        }
    }
}