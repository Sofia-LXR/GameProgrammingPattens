using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class SingletonProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("饿汉式单例模式");
            Console.WriteLine();
            //通过new实例化会报错
            Singleton g = new Singleton();

            //只能通过getInstance得到对象
            Singleton g1 = Singleton.getInstance();
            Console.ReadKey();

            Console.WriteLine("懒汉式单例模式");
            Console.WriteLine();
            Console.WriteLine("单线程环境");
            for(int i = 0; i < 10; i++)
            {
                LazySingleton singleton = LazySingleton.getInstance();
            }
            Console.ReadKey();
        }
    }
}
