using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.clases
{
    public class tabMul2
    {
        public void mul2()
        {
			Console.Clear();
			for (int i = 2; i <= 9; i++)
			{
				Console.WriteLine("\nTabla de multiplicar del {0}", i);
				Console.WriteLine("------------------------------");
				for (int j = 1; j <= 10; j++)
				{
					Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
				}
			}

		}
    }
}
