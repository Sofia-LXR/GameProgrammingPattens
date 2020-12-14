using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 构建一个使用Builder接口的对象。它主要是用于创建一个复杂的对象。
    /// 它主要有两个作用
    ///     一是：隔离了客户与对象的生产过程，
    ///     二是：负责控制产品对象的生产过程。
    /// </summary>
    /// 
    public class HouseDirector
    {
        HouseBuilder houseBuilder = null;

        //通过构造器传入houseBuilder
        public HouseDirector(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
        
        //或者通过set方法传入houseBuilder 
        public void setHouseBuild (HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        //如何处理建造房子的流程 交给指挥者
        public House ConstructHouse()
        {
            houseBuilder.buildBasic();
            houseBuilder.buildWalls();
            houseBuilder.Rooefd();
            return houseBuilder.BuildHouse();
                 
        }
    }
}
