using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    public class vector
    {
        public void vector1()
        {
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };

            Console.Clear();

            imprimirVector(edad, " original");

            for (int ciclo = 1; ciclo <= edad.Length; ciclo++)
            {

                int aux = 0;
                for (int i = 0; i < edad.Length - ciclo; i++)
                {
                    if (edad[i] < edad[i + 1])
                    {
                        aux = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = aux;
                    }
                }
            }
            imprimirVector(edad, " ordenado");
            
        }
        static void imprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo" + titulo);
            foreach (int elemento in vector)
            {
                Console.Write("[ " + elemento + " ] ");
            }
            Console.WriteLine("\n ");
        }
    }
}
