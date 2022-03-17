using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo
{
    internal class ActionFuncDemo
    {
        //////////////////////////////////////////////////////////
        delegate void MyDelegate1(int num, string name);
        delegate int MyDelegate2(int num, string name, int age);

        public void TestWithDelegate()
        {
            MyDelegate1 myDelegate1 = Show;
            myDelegate1(10, "Raman");

            MyDelegate2 myDelegate2 = Show2;
            int ans = myDelegate2(10, "Hoha", 45);
        }
        //////////////////////////////////////////////////////////

        public void TestWithoutDelegate()
        {
            Action<int, string> myDelegate1 = Show;
            myDelegate1(10, "Raman");

            Func<int, string, int, int> myDelegate2 = Show2;
            int ans = myDelegate2(10, "Hoha", 45);
        }

        public static void Show(int num, string name)
        {
            Console.WriteLine($"{name}, {num}");
        }

        public static int Show2(int num, string name, int age)
        {
            Console.WriteLine($"{name}, {num}, {age}");
            return num * 2;
        }
    }
}
