using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Light light = new Light(new Off());

            Console.WriteLine("默认电源为Off\n提示：按下空格键，打开电源");
            Console.ReadKey();
            light.PressSwich();

            Console.WriteLine("\n提示：按下空格键，关闭电源");
            Console.ReadKey();
            light.PressSwich(); 
            Console.ReadKey();
        }
    }
    //解析：第一次 Light类 默认用 Off类 去传值
    //这就让 Light类的 state 为 Off类 实例化的
    //在调用时，只会调用  Off类 中的重写方法 PressSwich
    //这里将 Light类 传递过去，只是为了让 Off类 里面也可以调用 Light类 其他的方法，
    //也可以转换其他的状态，在这里只是在里面做了一下状态转换，其实它的功能远不止如此

    //第2次调用PressSwich方法时，这时Light类状态state 已经被 On类 赋值，
    //所以调用了On类 的PressSwich方法，这时就打印了灯关了
}
