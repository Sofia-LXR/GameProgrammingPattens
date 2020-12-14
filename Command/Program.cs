using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  提示：空格键进下一步\n命令模式过程输出:");
            Console.ReadKey();

            CommandController commandController = new CommandController();//创建命令调用者-遥控器

            Light light = new Light();//创建命令接收者-灯

            LightOnCommand lightoncommand = new LightOnCommand(light);//创建（继承后的）命令

            commandController.setCommand(lightoncommand);//向遥控器传入开灯命令
            commandController.buttonisPressed();//向遥控器传入按下按钮的命令

            Console.ReadKey();
        }
    }
}
