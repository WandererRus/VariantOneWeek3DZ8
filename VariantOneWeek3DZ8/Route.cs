using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariantOneWeek3DZ8
{
    class Route
    {
        public int BusNumber { get; set; }

        public string BusType { get; set; }

        public string BusDestination { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }


        public Route(int number, string type, string destination, DateTime datefrom, TimeSpan timefrom, DateTime dateto, TimeSpan timeto) 
        { 
            BusNumber = number;
            BusType = type;
            BusDestination = destination;
            DateFrom = datefrom;
            DateFrom = DateFrom + timefrom;
            DateTo = dateto;
            DateTo = DateTo + timeto;
        }

        public override string ToString()
        {
            return BusNumber.ToString() + "                                 |          " + BusType.ToString() + "               |       " + BusDestination.ToString() + "                             |       " + DateFrom.ToString() + "       |      " + DateTo.ToString();
        }
    }
}
