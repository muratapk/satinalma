using System.ComponentModel.DataAnnotations;

namespace satinalma.Models
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }
        public int ? customer_id { get; set; }
        public DateTime ? order_date { get; set; }
        public decimal total_amount { get; set; }
        public string status { get; set; } = string.Empty;
        public string shipping_address { get; set; } = string.Empty;
        public string billing_address { get; set; } = string.Empty;
        public virtual ICollection<OrderDetails>? Details { get; set; }
        public virtual ICollection<Payments>? Payments { get; set; }    
    }
}
