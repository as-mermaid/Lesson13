using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("СПБ", 30, 10, 15);
            Console.WriteLine(building.Print());

            MultiBuilding multiBuilding = new MultiBuilding("МСК", 50, 25, 50, 15);
            Console.WriteLine(multiBuilding.Print());

            Console.ReadKey();
        }
    }
}
