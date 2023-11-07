using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RExamen_JSVE.Logica
{
    internal class Class1
    {
        public void Ejercicio1()
        {
            int[,] tabla =
            {
        {500,3000,100,400 },
        {1000,150,200,500 },
        {250,1800,2900,300 },
        {400,130,90,2400 },
        {60,20,4000,3600, }
            };

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.Write(tabla[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nel vendedor 1 tuvo de ganancias de {tabla[0, 0] + tabla[1, 0] + tabla[2, 0] + tabla[3, 0] + tabla[4, 0]}");
            Console.WriteLine($"el vendedor 2 tuvo de ganancias de {tabla[0, 1] + tabla[1, 1] + tabla[2, 1] + tabla[3, 1] + tabla[4, 1]}");
            Console.WriteLine($"el vendedor 3 tuvo de ganancias de {tabla[0, 2] + tabla[1, 2] + tabla[2, 2] + tabla[3, 2] + tabla[4, 2]}");
            Console.WriteLine($"el vendedor 4 tuvo de ganancias de {tabla[0, 3] + tabla[1, 3] + tabla[2, 3] + tabla[3, 3] + tabla[4, 3]}");

            Console.WriteLine($"\nel producto 1 tuvo de ganancias de {tabla[0, 0] + tabla[0, 1] + tabla[0, 2] + tabla[0, 3]}");
            Console.WriteLine($"el producto 2 tuvo de ganancias de {tabla[1, 0] + tabla[1, 1] + tabla[1, 2] + tabla[1, 3]}");
            Console.WriteLine($"el producto 3 tuvo de ganancias de {tabla[2, 0] + tabla[2, 1] + tabla[2, 2] + tabla[2, 3]}");
            Console.WriteLine($"el producto 4 tuvo de ganancias de {tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3, 3]}");
            Console.WriteLine($"el producto 5 tuvo de ganancias de {tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4, 3]}");



        }

        public void Ejercicio2()
        {
            //curp LOLI050825MFGLYD02.
            Console.WriteLine("Ingresame tu curp");

            string curp = Console.ReadLine();
            if (curp.Length >= 18)
            {
                string sexo = curp.Substring(10, 1);
                string nacimientofec = curp.Substring(4, 6);

                string genero = (sexo == "H") ? "Hombre" : (sexo == "M") ? "Mujer" : "Eres alien o que?";

                string año = nacimientofec.Substring(0, 2);
                string mes = nacimientofec.Substring(2, 2);
                string dia = nacimientofec.Substring(4, 2);
                string fecnac = $"{dia}/{mes}/{año}";

                Console.WriteLine($"Usted es de sexo: {genero}");
                Console.WriteLine($"y su fecha de nacimiento es: {fecnac}");
            }
            else
            {
                Console.WriteLine("no se encontro la curp");
            }
        }
        public void Ejercicio3()
        {
            int[] arreglo = new int[10];
            Random all = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int cali = all.Next(1, 100);
                arreglo[i] = cali;
            }
            Console.WriteLine();

            Console.WriteLine("la lista de calificaciones desordenada es:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();

            int menor = 0;
            int pos = 0;
            int tem = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                menor = arreglo[i];
                pos = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] > menor)
                    {
                        menor = arreglo[j];
                        pos = j;
                    }

                }
                if (pos != i)
                {
                    tem = arreglo[pos];
                    arreglo[pos] = arreglo[i];
                    arreglo[i] = tem;
                }
            }
            Console.WriteLine("la lista de calificaciones ogrnizada es:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();

            int num = 75;
            int inicio = 0;
            int fin = arreglo.Length - 1;
            int resultado = -1;
            bool encontrar = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == num)
                {
                    Console.WriteLine($"el numero {arreglo[medio]} esta en la posicion {medio}");
                    encontrar = true;
                    break;
                }
                if (arreglo[medio] > num)
                {
                    inicio = medio - 1;
                    medio = (inicio + fin) / 2;

                }
                else
                {
                    fin = medio + 1;
                    medio = (inicio + fin) / 2;

                }
            }
            if (!encontrar)
            {
                Console.WriteLine($"No se encuentra el numero {num}");
            }
            Console.WriteLine();
        }



    }
}


