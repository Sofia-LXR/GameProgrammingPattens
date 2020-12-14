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
    public class CommonHouse : HouseBuilder
    {

        public override void buildBasic()//老娘要重写
        {
            Console.WriteLine("普通房子-打地基-5米");
        }

        public override void buildWalls()
        {
            Console.WriteLine("普通房子-砌墙-10cm");
        }

        public override void Rooefd()
        {
            Console.WriteLine("普通房子-屋顶");
        }
    }
}
