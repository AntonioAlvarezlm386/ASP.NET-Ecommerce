using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class STATE
    {
        public string STATE_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public virtual ICollection<CITY> CITIES { get; set; }
        public virtual ICollection<LOCALITY> LOCALITIES {  get; set; }
    }
}
