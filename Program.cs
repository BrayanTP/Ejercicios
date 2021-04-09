using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Ejercicios");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Par o impar");
                Console.WriteLine("2. Tabla de multiplicar por teclado");
                Console.WriteLine("3. Tabla de multiplicar 2-9");
                Console.WriteLine("4. Numero primo");
                Console.WriteLine("5. Ordenar vector");
                Console.WriteLine("6. Definir si existe");
                Console.WriteLine("7. Buscar mayor y menor");
                Console.WriteLine("8. Palindromo");
                Console.WriteLine("9. Fibonacci");

                Console.Write("Escoja una opción");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        clases.ParImpar op1 = new clases.ParImpar();
                        op1.par();
                        break;
                    case 2:
                        clases.tabMul op2 = new clases.tabMul();
                        op2.mul();
                        Console.ReadKey();
                        break;
                    case 3:
                        clases.tabMul2 op3 = new clases.tabMul2();
                        op3.mul2();
                        Console.ReadKey();
                        break;
                    case 4:
                        clases.primo op4 = new clases.primo();
                        op4.primo1();
                        Console.ReadKey();
                        break;
                    case 5:
                        clases.vector op5 = new clases.vector();
                        op5.vector1();
                        Console.ReadKey();
                        break;
                    case 6:
                        clases.Existe op6 = new clases.Existe();
                        op6.existe1();
                        Console.ReadKey();
                        break;
                    case 7:
                        clases.mayor op7 = new clases.mayor();
                        op7.mayor1();
                        Console.ReadKey();
                        break;
                    case 8:
                        clases.fibbo op8 = new clases.fibbo();
                        op8.nacci();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("No valido");
                        break;
                }
            } while (op != 0);
        }
    }
}
