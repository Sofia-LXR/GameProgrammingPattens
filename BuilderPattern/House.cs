using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Product（产品角色）：一个具体的产品对象
    /// </summary>
    public class House
    {
        private String baise;
        private string wall;
        private string roofed;

        public string GetBaise()
        {
            return baise;
        }
        public void SetBaise(string baise)
        {
            this.baise = baise;
        }

        public string GetWall()
        {
            return wall;
        }

        public void SetWall(string wall)
        {
            this.wall = wall; ;
        }

        public string GetRoofed()
        {
            return roofed;
        }

        public void  SetRoofed(String Roofed)
        {
            this.roofed = roofed;
        }
    }
}
