using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    /// <summary>
    /// 饿汉式单例模式
    /// </summary>
    public class Singleton
    {
        //私有化构造方法，使得该类无法在外部通过new进行实例化
        private void Single()
        {
            Console.WriteLine("这里是私有化构造方法");//不打印
        }

        //准备一个类属性，指向一个实例化对象，因为是类属性，所以只有一个
        private static Singleton instance = new Singleton();

        //public static方法，提供给调用者获取下面代码的对象
        public static Singleton getInstance()
        {
            Console.WriteLine("通过一个static方法,调用类属性");
            return instance;
        }
    }
    /// <summary>
    /// 懒汉式单例模式
    /// </summary>
    public class LazySingleton
    {
        //定义对象赋值为null
        private static LazySingleton singleton = null;

        //定义私有构造方法
        private LazySingleton()
        {
            Console.WriteLine("创建了懒汉式单例模式对象");
        }

        //返回对象
        public static LazySingleton getInstance()
        {
            // 判断如果对象不为null，就不用进入同步块，这样可以提高性能
            if(singleton == null)
            {
                //判断对象为null，才创建对象
                singleton = new LazySingleton();
            }
            return singleton;
        }
    }


}
