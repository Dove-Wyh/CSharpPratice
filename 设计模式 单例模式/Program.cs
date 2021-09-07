using System;

namespace 设计模式_单例模式
{
    class SingletonPratice
    {
        //定义私有构造函数避免外部创建实例
        private SingletonPratice()
        {

        }

        //静态构造函数只会在第一次被使用时调用,且只会调用一次,是线程安全的
        public static SingletonPratice Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            //定义私有构造函数避免SingletonPratice再创建实例 如
            static Nested()
            {
                Console.WriteLine("这个不知道是干嘛的");
            }
            internal static SingletonPratice instance = new SingletonPratice();
        }

        public void Print()
        {
            Console.WriteLine("利用私有嵌套类型的特性,做到了只在需要的时候才会创建实例,并且是线程安全的!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingletonPratice.Instance.Print();
        }
    }
}
