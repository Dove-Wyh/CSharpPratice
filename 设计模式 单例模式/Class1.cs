using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式_单例模式
{
    class Class1
    {
        public static int a = 1;

        static Class1()
        {
            Console.WriteLine("Class1 的静态构造函数");
        }

        public Class1()
        {
            Console.WriteLine("Class1 的构造函数");
        }
    }

    class Class2 : Class1
    {
        public static int aa = 2;

        static Class2()
        {
            Console.WriteLine("Class2 的静态构造函数");
        }

        public Class2()
        {
            Console.WriteLine("Class2 的构造函数");
        }
    }

    class Class3 : Class2
    {
        public static int aaa = 3;

        static Class3()
        {
            Console.WriteLine("Class3 的静态构造函数");
        }

        public Class3()
        {
            Console.WriteLine("Class3 的构造函数");
        }

        public static void Print()
        {
            Console.WriteLine("Class3 的静态成员函数");
        }
    }

    class Class4
    {
        public static int a = 4;

        static Class4()
        {
            Console.WriteLine("Class4 的静态构造函数");
            Console.WriteLine(Class5.a);
        }

        public static void Print()
        {
            Console.WriteLine("Class4 的静态成员函数");
        }
    }

    class Class5
    {
        public static int a = 5;

        static Class5()
        {
            Console.WriteLine("Class5 的静态构造函数");
        }
    }
}
