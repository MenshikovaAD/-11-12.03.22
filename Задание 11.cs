using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Задание_11
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Программа решает уравнени 0 = kx + b");
            Console.WriteLine("Вещественные числа вводятся через (,) ");
            Console.WriteLine("Введите k :");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k,b);
            double root = equation.Root();
            Console.WriteLine("Ответ x : {0}", root);
            Console.ReadKey();
        }
    }
}


