using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 灯
    /// Receiver(接收者)：命令执行者
    /// </summary>
    public class Light
    {
        
        public void On()
        {
            Console.WriteLine("开灯");
        }
        public void Off()
        {
            Console.WriteLine("关灯");
        }
    }
}
