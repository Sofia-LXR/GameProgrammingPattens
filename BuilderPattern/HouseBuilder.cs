using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Builder（抽象建造者）：创建一个Product对象的各个部件指定的接口/抽象类
    /// </summary>
    public abstract class HouseBuilder
    {
        protected House house = new House();

        //将创建的流程写好，抽象的方法
        public abstract void buildBasic();
        public abstract void buildWalls();
        public abstract void Rooefd();

        //产品完成后，将产品返回
        public House BuildHouse()
        {
            return house;
        }
    }
    
}
