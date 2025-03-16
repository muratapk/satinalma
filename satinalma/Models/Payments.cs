using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace satinalma.Models
{
    public class Payments
    {
        [Key]
        public int payment_id { get;set; }
        public int ? order_id { get; set; }
        public DateTime payment_date { get; set; }
        public decimal amount { get; set; }
        public string payment_method { get; set; } = string.Empty;
        public string payment_status { get; set; }=string.Empty;
        public virtual Orders ? Orders { get; set; } 
    }
}
