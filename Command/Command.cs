using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 命令接口：操作的按钮，也可添加其他操作undo 
    /// Command(命令接口)：负责将操作封装成统一的方法
    /// </summary>
    public abstract class  Command
    {
        public abstract void execute();
    }
}
