using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// 具体工厂角色
    /// </summary>
    public class UndergraduateFactory:IFactory
    {
        public  Leifeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
}
