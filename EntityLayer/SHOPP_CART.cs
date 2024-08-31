namespace EntityLayer
{
    public class SHOPP_CART
    {
        public int CART_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int ITEMS { get; set; }
        public virtual CLIENT CLIENT { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
