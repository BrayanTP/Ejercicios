using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    public class mayor
    {
        public void mayor1()
        {
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

            int edadmayor = 0;
            string psmayor = null;

            int edadmenor = 0;
            string psmenor = null;
            Console.Clear();
            for (int indice = 0; indice < nombre.Length; indice++)
            {

                
                if (edad[indice] > edadmayor)
                {
                    edadmayor = edad[indice];
                    psmayor = Convert.ToString(indice);
                }

                
                if (edad[indice] < edadmenor)
                {
                    edadmenor = edad[indice];
                    psmenor = Convert.ToString(indice);
                }
            }
            Console.WriteLine(" El Usuario mayor es " + psmayor + " tiene " + edadmayor + " Anos de edad");
            Console.WriteLine(" El Usuario menor es " + psmenor + " tiene " + edadmenor + " Anos de edad");
        }
        static void ImprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo " + titulo);

            foreach (string elemento in vector)
            {
                Console.Write("[ " + elemento + " ] ");
            }
            Console.WriteLine("\n");
        }
    }
}
