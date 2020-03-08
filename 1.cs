using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            List<int> union = new List<int>();
            List<int> interseccion = new List<int>();
            List<int> complemento = new List<int>();

            int temp = 0, n = 31;

            List<int> u = new List<int>();
            for (int i = 0; i < n; i++)
                u.Add(i);

            int[] a = {0, 15, 6, 6, 12, 3, 0, 12, 18, 12, 18, 6, 9};
            int[] b = {4, 0, 18, 6, 6, 16, 6, 0, 12, 10, 14, 8, 18, 2, 12, 2};

            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }

            for (int j = 0; j < b.Length; j++)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        temp = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = temp;
                    }
                }
            }

            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (a[j] == b[i])
                    {
                        interseccion.Add(b[i]);
                    }
                }
            }

            interseccion.Sort();
            for (int i = 0; i < interseccion.Count - 1; i++)
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }

            Console.Write("Intersección: ");
            for (int i = 1; i < interseccion.Count; i++)
                Console.Write(interseccion[i] + ", ");

            
            for (int i = 0; i < a.Length; i++)
                union.Add(a[i]);
            for (int i = 0; i < b.Length; i++)
                union.Add(b[i]);

            union.Sort();
            for (int i = 0; i < union.Count - 1; i++)
            {
                if (union[i] == union[i + 1])
                {
                    union.RemoveAt(i);
                    i = 0;
                }
            }

            Console.WriteLine();
            Console.Write("Union: ");
            for (int i = 1; i < union.Count; i++)
                Console.Write(union[i] + ", ");

            bool esta;
            for (int i = 0; i < u.Count; i++)
            {
                esta = true;
                for (int j = 0; j < union.Count; j++)
                {
                    if (u[i] == union[j])
                    {
                        esta = false;
                        break;
                    }
                }
                if (esta == true)
                {
                    complemento.Add(u[i]);
                }
            }

            Console.WriteLine();
            Console.Write("complemento: ");
            for (int i = 0; i < complemento.Count; i++)
            Console.Write(complemento[i] + ", ");
        }
    }
}
