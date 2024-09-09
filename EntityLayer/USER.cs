using System;

namespace EntityLayer
{
    public class USER
    {
        public int USER_ID { get; set; }
        public string NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public bool RESET_PSWD { get; set; }
        public bool ACTIVE { get; set; }
        public DateTime CREATED_AT { get; set; }
    }
}
