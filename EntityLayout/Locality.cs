using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class Locality
    {
        public int LOCALITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public State oSTATE { get; set; }
        public City oCITY { get; set; }
    }
}
