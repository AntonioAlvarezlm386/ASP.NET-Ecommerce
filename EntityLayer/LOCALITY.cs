using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class LOCALITY
    {
        public string LOCALITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string CITY_ID { get; set; }
        public string STATE_ID { get; set; }   
        public virtual STATE STATE { get; set; }
        public virtual CITY CITY { get; set; }
        public virtual ICollection<SALE> SALES { get; set; }    
    }
}
