using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace satinalma.Models
{
    public class customers
    {
        [Key]
        public int customer_id { get;set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; }=string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string password_hash { get; set; } = string.Empty;
        public string shipping_address { get; set; } = string.Empty;
        public string billing_address { get; set; } = string.Empty;
        public virtual ICollection<product_reviews>? reviews { get; set; }
        public virtual ICollection<cart>? Carts { get; set; }    
    }
}
