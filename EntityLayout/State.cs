using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class State
    {
        public string STATE_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public virtual ICollection<City> CITIES { get; set; }
        public virtual ICollection<Locality> LOCALITIES {  get; set; }
    }
}
