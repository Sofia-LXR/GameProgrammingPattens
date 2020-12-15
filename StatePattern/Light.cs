using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 电灯类
    /// </summary>
    public class Light
    {
        private LightState state;

        public Light(LightState state)
        {
            this.state = state;
        }

        public void PressSwich()
        {
            state.PressSwich(this);
        }

        public LightState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
