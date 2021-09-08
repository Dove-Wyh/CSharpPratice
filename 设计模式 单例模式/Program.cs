using System;

namespace 设计模式_单例模式
{
    class SingletonPratice
    {
        //1.静态构造函数没有参数,但是可以与无参构造函数共存
        //2.静态构造函数既没有访问修饰符,不可以被继承,并且只能有一个,且只会调用一次,是线程安全的
        //3.静态构造函数只会在在创建第一个类实例或任何静态成员被引用时时调用,当有一个静态变量被引用时就初始化所有静态变量
        //4.如果没有写静态构造函数,而类中包含带有初始值设定的静态成员,那么编译器会自动生成默认的静态构造函数

        static SingletonPratice()
        {
            Console.WriteLine("这个可以不写的1");
        }

        int a = 1;
        //定义私有构造函数避免外部创建实例
        private SingletonPratice()
        {
            Console.WriteLine("单例类的构造函数!");
        }

        
        public static SingletonPratice Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            //如果没有写静态构造函数,而类中包含带有初始值设定的静态成员,那么编译器会自动生成默认的静态构造函数
            static Nested()
            {
                Console.WriteLine("这个可以不写的2");
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

            //静态构造函数,静态成员变量,静态成员函数实验
            //Class1 c = new Class3();
            //Class4.Print();
        }
    }
}
