using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    class tabMul
    {
        public void mul()
        {
            int f;
            
            Console.Clear();
            Console.Write("Digite un numero: ");
            f = Convert.ToInt32(Console.ReadLine());

            
                Console.WriteLine($"\nTabla de multiplicar del {f}");
                Console.WriteLine("------------------------------");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{3} * {1} = {2}", f, j, (f * j));
                }
            
        }
    }
}
