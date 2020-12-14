using Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            UndergraduateFactory factory = new UndergraduateFactory();
            Leifeng student = factory.CreateLeiFeng();

            student.Sweep();
            student.Wash();
            student.BuyRice();

            Console.WriteLine("\n --------------------------");
            Console.ReadKey();

            IFactory factory2 = new VolunteerFactory();
            Leifeng volunteer = factory2.CreateLeiFeng();

            volunteer.Sweep();
            volunteer.Wash();
            volunteer.BuyRice();

            Console.ReadKey();
        }
    }
}
