using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace satinalma.Models
{
    public class product
    {
        [Key]
        public int product_id { get;set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; }=string.Empty;
        public decimal price { get; set; }
        public int ? stock_quantity { get; set; }
        public int ? category_id { get; set; }
        public string Picture_Image { get; set; } = string.Empty;
        public DateTime ? created_at  { get;set; }
        [NotMapped]
        
        virtual public IFormFile ? Dosya { get; set; }
        virtual public categories? Categories { get; set; }
        public virtual ICollection<OrderDetails>? Details { get; set; }
        public virtual ICollection<product_reviews> ?reviews { get; set; }
        public virtual ICollection<cart>? Carts { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
