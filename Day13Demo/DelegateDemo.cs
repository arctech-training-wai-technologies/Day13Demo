using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo
{
    public static class DelegateDemo
    {
        public delegate int Xyz(int num1, int num2);

        public static void Test()
        {
            Xyz obj = Sum;

            int ans1 = obj(10, 20);
            int ans2 = Sum(20, 30);

            obj = Subtract;
            int ans3 = obj(100, 10);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
            Console.WriteLine(ans3);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
