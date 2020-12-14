using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// 具体产品角色
    /// </summary>
    public class Volunteer :Leifeng
    {
        public  void Sweep()
        {
            Console.WriteLine("方法一：社区志愿者帮忙打扫卫生");
        }
        public  void Wash()
        {
            Console.WriteLine("方法二：社区志愿者帮忙洗衣服");
        }
        public  void BuyRice()
        {
            Console.WriteLine("方法三：社区志愿者帮忙买东西");
        }
    }

    public class Undergraduate : Leifeng
    {
        public  void BuyRice()
        {
            Console.WriteLine("方法一：大学生帮忙买米");
        }
        public  void Wash()
        {
            Console.WriteLine("方法二：大学生帮忙洗衣服");
        }
        public  void Sweep()
        {
            Console.WriteLine("方法三：大学生帮忙打扫卫生");
        }
    }
}
