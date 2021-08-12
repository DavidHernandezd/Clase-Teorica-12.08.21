using System;
using System.Collections.Generic;

namespace Clase_Teorica_12._08._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamdo de metodos loops
            loops();
            Console.ReadLine();
        }

        //bucles
        public static void loops()
        {
            int n = 0;
            //Escribir un cilo que permita capturar los elementos a
            //almacenar  en el arreglo de numbers con un tamaño de 10 
            int[] numbers = new int[10];

            /* numbers[0] = n;
             numbers[1] = n;
             numbers[2] = n;*/
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor para el elemento {0}: ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }


            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }
            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posición {0} : {1}", j, numbers[j]);
            }
            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);

                static void Main(string[] args)
                {
                    Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

                    EmployeeList.Add("Jose Flores", "Programador");
                    EmployeeList.Add("Miranda Campos", "Gerente");
                    EmployeeList.Add("Carmen Valladares", "Arquitecta");

                    Dictionary<string, int> Students = new Dictionary<string, int>();
                    Students.Add("Jose Flores", 22);
                    Students.Add("Miranda Campos", 20);
                    Students.Add("Carmen Valladares", 25);

                    foreach (KeyValuePair<string, string> employee in EmployeeList)
                    {
                        Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
                    }

                    Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList);

                    Console.ReadKey();
                }
            }
        }
    }
}
        