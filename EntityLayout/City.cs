using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class City
    {
        public int CITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public State oSTATE { get; set; }
    }
}
