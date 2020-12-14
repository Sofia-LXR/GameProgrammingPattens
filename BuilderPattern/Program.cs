using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonHouse commonHouse = new CommonHouse();
            HouseDirector houseDirector001 = new HouseDirector(commonHouse);
            House house001 = houseDirector001.ConstructHouse();

            HighBuilding highBuilding = new HighBuilding();
            HouseDirector houseDirector002 = new HouseDirector(highBuilding);
            House house002 = houseDirector002.ConstructHouse();


            Console.ReadKey();
        }
    }
}
