using System.Security.Cryptography.Xml;

namespace satinalma.Models
{
    public class OrderDetails
    {
        public int order_detail_id { get;set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal unit_price { get; set; }
        public virtual Orders ? Orders { get; set; } 
        //buradaki kod ile orders tablosu arasında bir ilişki oluştur
        public virtual product ? Product { get; set; }
       //buradaki kod ile ürünler tablosu arasında bir ilişki oluştur 
       
    }
}
