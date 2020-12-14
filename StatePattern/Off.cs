using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 具体状态类：关
    /// </summary>
    public class Off:LightState
    {
        public override void PressSwich(Light light)
        {
            Console.WriteLine("第一次按下开关，电源接通");
            light.State = new On();
        }
    }
}
