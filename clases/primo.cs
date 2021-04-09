using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    public class primo
    {
        public void primo1()
        {
            int a = 0, num;
            Console.Clear();
            Console.WriteLine("Digite un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine($"{num} No es primo");
            }
            else
            {
                Console.WriteLine($"{num} Si es primo");
            }
            
        }
    }
}
