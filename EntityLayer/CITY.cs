﻿using System.Collections.Generic;

namespace EntityLayer
{
    public class CITY
    {
        public string CITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string STATE_ID { get; set; }
        public virtual STATE STATE { get; set; }
        public virtual ICollection<LOCALITY> LOCALITIES { get; set; }
    }
}
