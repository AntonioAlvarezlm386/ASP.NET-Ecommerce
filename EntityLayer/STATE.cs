using System.Collections.Generic;

namespace EntityLayer
{
    public class STATE
    {
        public string STATE_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public virtual ICollection<CITY> CITIES { get; set; }
        public virtual ICollection<LOCALITY> LOCALITIES { get; set; }
    }
}
