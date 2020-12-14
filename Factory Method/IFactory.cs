using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// 抽象工厂角色
    /// </summary>
    public interface IFactory
    {
        Leifeng CreateLeiFeng();
    }
}
