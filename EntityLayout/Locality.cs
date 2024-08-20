using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class Locality
    {
        public string LOCALITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string CITY_ID { get; set; }
        public string STATE_ID { get; set; }   
        public virtual State STATE { get; set; }
        public virtual City CITY { get; set; }
        public virtual ICollection<Sale> SALES { get; set; }    
    }
}
