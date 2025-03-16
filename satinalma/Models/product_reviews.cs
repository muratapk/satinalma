using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace satinalma.Models
{
    public class product_reviews
    {
       [Key]
       public int review_id { get;set; }
       public int product_id { get; set; }
        public int customer_id { get; set; }
        public int rating { get; set; }
        public string comment { get; set; } = string.Empty;
        public DateTime review_date { get; set; }
        public virtual product ?Product { get; set; }
        public virtual customers? Customers { get; set; }
       
        
    }
}
