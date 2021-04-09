using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    public class ParImpar
    {
        public void par()
        {
            int f;
            Console.Clear();
            Console.Write("Digite un numero: ");
            f = Convert.ToInt32(Console.ReadLine());

            if(f % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            } else Console.WriteLine("El numero es impar");
        }

    }
}
