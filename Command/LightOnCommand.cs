using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 开灯命令：将请求封装成命令对象
    /// ConcreateCommand(命令实现类)：负责将命令真正执行者的操作封装起来
    /// </summary>
    public class LightOnCommand :Command
    {
        private Light light;//这里使用委托解耦
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public override void execute()//重写
        {
            Console.WriteLine("灯接收到开灯命令，即将打开灯");
            light.On();
        }
    }
}
