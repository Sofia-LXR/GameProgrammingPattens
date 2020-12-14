using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 抽象的电灯状态类，相当于state类
    /// </summary>
    public abstract class LightState
    {
        public abstract void PressSwich(Light light);
    }
}
