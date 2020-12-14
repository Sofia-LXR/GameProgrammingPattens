using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 遥控器
    /// Invoke(命令调用者)：调用者负责执行命令
    /// </summary>
    class CommandController
    {
        private Command solt;

        public void setCommand(Command command)
        {
            Console.WriteLine("将开灯命令传入到遥控器上");
            solt = command;
        }
        
        public void buttonisPressed()
        {
            Console.WriteLine("遥控器按钮按下，执行命令");
            solt.execute();
        }
    }
}
