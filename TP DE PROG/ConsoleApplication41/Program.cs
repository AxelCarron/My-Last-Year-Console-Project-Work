using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
                int[,] S2 = new int[7, 7];
                for (int c = 0; c < 7; c++)
                {
                    for (int f = 0; f < 7; f++)
                    {
                        if (f == 0 || f == 6 || c == 0 || c == 6)
                            Console.Write(" " + 3);
                        else if (f == 1 || f == 5 || c == 1 || c == 5)
                            Console.Write(" " + 2);
                        else if (f == 2 || f == 4 || c == 2 || c == 4)
                            Console.Write(" " + 1);
                        else
                            Console.Write(" " + 0);
                    }
                    Console.WriteLine(" ");
                }


                Console.Write("\n");
                /////////////////////////////////////////////////2
                int[,] Matriz = new int[6, 8];
                int[,] Espejo = new int[6, 8];
                Random Rng = new Random();
                for (int f = 0; f < 6; f++)
                {
                    for (int c = 0; c < 8; c++)
                    {
                        Matriz[f, c] = Rng.Next(0, 10);
                        Console.Write(" " + Matriz[f, c]);
                        Espejo[f, c] = Matriz[f, c] + Espejo[f, c];
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
                for (int f = 0; f < 6; f++)
                {
                    for (int c = 7; c >= 0; c--)
                    {
                        Console.Write(" " + Espejo[f, c]);
                    }
                    Console.WriteLine(" ");
                }

                Console.Write("\n");
                /////////////////////////////////////////////////////////3
                List<string> P = new List<string>();
                Personas(P);


                Console.Clear();
                Console.WriteLine("Lista Ingresada: ");
                P.Sort();
                Lista(P);



                Console.Write("\n");
                //////////////////////////////////////////////////////4

                int[] array1 = new int[5];
                int[] array2 = new int[5];
                int[] reslutado = new int[5];
                RESULTANTE(array1, array2, reslutado);

                Console.Write("\n");
                ////////////////////////////////////////////////////////5


                Random RNG = new Random();
                int[] Tiro1 = { RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7) };
                int[] Tiro2 = { RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7) };
                int[] Tiro3 = { RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7) };
                int[] Tiro4 = { RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7) };
                int[] Tiro5 = { RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7), RNG.Next(1, 7) };
                List<int> GNRL = new List<int>();
                GNRL.AddRange(Tiro1);
                GNRL.AddRange(Tiro2);
                GNRL.AddRange(Tiro3);
                GNRL.AddRange(Tiro4);
                GNRL.AddRange(Tiro5);
                TIROS(Tiro1, Tiro2, Tiro3, Tiro4, Tiro5);

                CONTEO(GNRL);
                Console.ReadKey();
            }
        public static void TIROS(int[] Tiro1, int[] Tiro2, int[] Tiro3, int[] Tiro4, int[] Tiro5)

        {
            Console.Write("Tiro 1: ");
            for (int f = 0; f < 5; f++)
            {
                Console.Write(" " + Tiro1[f]);
            }
            Console.Write("\n");

            Console.Write("Tiro 2: ");
            for (int f = 0; f < 5; f++)
            {
                Console.Write(" " + Tiro2[f]);
            }
            Console.Write("\n");

            Console.Write("Tiro 3: ");
            for (int f = 0; f < 5; f++)
            {
                Console.Write(" " + Tiro3[f]);
            }
            Console.Write("\n");

            Console.Write("Tiro 4: ");
            for (int f = 0; f < 5; f++)
            {
                Console.Write(" " + Tiro4[f]);
            }
            Console.Write("\n");

            Console.Write("Tiro 5: ");
            for (int f = 0; f < 5; f++)
            {
                Console.Write(" " + Tiro5[f]);
            }

        }
        public static void RESULTANTE(int[] array1, int[] array2, int[] resultado)
        {
            Random GH = new Random();

            for (int i = 0; i < 5; i++)
            {
                array1[i] = GH.Next(1, 9);
                if (i == 0)
                    Console.Write("Array1:");
                Console.Write(" " + array1[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = GH.Next(1, 9);
                if (i == 0)
                    Console.Write("Array2:");
                Console.Write(" " + array2[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                    Console.Write("Resultante:");
                resultado[0] = array1[0] * array2[0] * array2[1] * array2[2] * array2[3] * array2[4];
                resultado[1] = array1[1] * array2[0] * array2[1] * array2[2] * array2[3] * array2[4];
                resultado[2] = array1[2] * array2[0] * array2[1] * array2[2] * array2[3] * array2[4];
                resultado[3] = array1[3] * array2[0] * array2[1] * array2[2] * array2[3] * array2[4];
                resultado[4] = array1[4] * array2[0] * array2[1] * array2[2] * array2[3] * array2[4];
                Console.Write(" " + resultado[i]);
            }
        }

        public static void Personas(List<string> P)
        {
            int continuar = 1;
            do
            {
                Console.Write("Ingrese apellido: ");
                string Apellido = Console.ReadLine();
                Console.Write("Ingrese nombre: ");
                string Nombre = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                string Edad = Console.ReadLine();
                P.Add(Edad + "; " + Apellido + ", " + Nombre);
                Console.Write("Continuar? SI = 1 - NO = 2: ");
                continuar = Convert.ToInt32(Console.ReadLine());
            } while (continuar == 1);


        }
        public static void Lista(List<string> P)
        {
            for (int i = 0; i < P.Count; i++)
            {
                char Sep = ';' ;
                string[] Separar = P[i].Split(Sep);
                Console.WriteLine(Separar[1]+ " " + Separar[0]);
            }
            
        } 
        public static void CONTEO(List<int> GNRL)
        {
            List<int> Generala = (GNRL);
            int[] Gen = new int[Generala.Count];
            int Cont = -1;
            for (int f = 0; f < Generala.Count; f++)
            {
                int Count = 1;
                for (int c = f + 1; c < Generala.Count; c++)
                {
                    if (Generala[f] == Generala[c])
                    {
                        Count++;
                        Gen[c] = Cont;
                    }

                }
                if (Gen[f] != Cont)
                {
                    Gen[f] = Count;
                }
            }

            Console.Write("\n");
            for (int f = 0; f < Generala.Count; f++)
            {
                if (Gen[f] != Cont)
                {
                    Console.WriteLine(Generala[f] + " = " + Gen[f]);
                }
            }

        }
    }
}
