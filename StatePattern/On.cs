using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 具体状态类：开
    /// </summary>
    public class On : LightState
    {
        public override void PressSwich(Light light)
        {
            Console.WriteLine("第二次按下开关，电源关闭");
            light.State = new Off();
        }

    }
}
