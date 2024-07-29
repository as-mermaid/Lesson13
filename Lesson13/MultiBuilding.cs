using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class MultiBuilding : Building
    {
        int numberOfStoreys;

        public int NumberOfStoreys
            {
                get
                {
                return numberOfStoreys;
                }
                set
                {
                numberOfStoreys = value;
                }
            }

        public MultiBuilding (string adress, double length, double width, double height, int numberOfStoreys)
            :base (adress, length, width,height)
        {
            this.numberOfStoreys = numberOfStoreys;
        }

        public override string Print ()
        {
            string result = base.Print ();
            return result + $", этажность - {numberOfStoreys}";
        }
    }
}
