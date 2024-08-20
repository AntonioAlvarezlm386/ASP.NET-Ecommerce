using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class Client
    {
        public int CLIENT_ID { get; set; }
        public string NAME { get; set; }
        public String LASTNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public bool RESET_PSWD { get; set; }
        public DateTime CREATED_AT { get; set; }
        public virtual ICollection<ShopCart> SHOPCARTS {  get; set; }
        public virtual ICollection<Sale> SALES { get; set; }
    }
}
