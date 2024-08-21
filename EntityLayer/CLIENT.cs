using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CLIENT
    {
        public int CLIENT_ID { get; set; }
        public string NAME { get; set; }
        public String LASTNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public bool RESET_PSWD { get; set; }
        public DateTime CREATED_AT { get; set; }
        public virtual ICollection<SHOPP_CART> SHOPCARTS {  get; set; }
        public virtual ICollection<SALE> SALES { get; set; }
    }
}
