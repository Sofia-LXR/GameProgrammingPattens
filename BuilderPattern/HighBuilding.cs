using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// ConcreteBuilder(具体建造者)：实现抽象接口，构建和装配各个部件
    /// </summary>
    class HighBuilding : HouseBuilder
    {
        public override void buildBasic()
        {
            Console.WriteLine("高楼-打地基-100米");
        }

        public override void buildWalls()
        {
            Console.WriteLine("高楼-砌墙-1米");
        }

        public override void Rooefd()
        {
            Console.WriteLine("高楼-透明屋顶");
        }
    }
}
