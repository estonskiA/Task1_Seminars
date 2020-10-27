using System;

namespace Zadacha1
{
    class Functions
    {
        public void f1()
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter left boarder (l): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter right boarder (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter step (s): ");
            double s = Convert.ToDouble(Console.ReadLine());
            for (double x = l; x <= r; x = x + s)
            {
                Console.WriteLine(a * Math.Pow(x, 2) + b * x + c);
            }
        }

        public void f2()
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter f0: ");
            double f0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter phi0: ");
            double phi0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter left boarder (l): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter right boarder (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter step (s): ");
            double s = Convert.ToDouble(Console.ReadLine());
            for (double x = l; x <= r; x = x + s)
            {
                Console.WriteLine(a * Math.Sin(2 * Math.PI * f0 * x + x * phi0));
            }
        }

        public void f3()
        {
            Console.WriteLine("Enter left boarder (l > 0): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter right boarder (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter step (s): ");
            double s = Convert.ToDouble(Console.ReadLine());
            for (double x = l; x <= r; x = x + s)
            {
                Console.WriteLine(Math.Sin(x)/x);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var f = new Functions();
            f.f1();
            f.f2();
            f.f3();
        }
    }
}
