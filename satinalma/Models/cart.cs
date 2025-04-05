using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace satinalma.Models
{
    public class cart
    {
    [Key] 
    public int cart_id { get; set; }
    public int ? customer_id { get; set; }
    public int ? product_id { get; set; }
    public int ? quantity {  get; set; }  
    public DateTime added_at {  get; set; } 
    public virtual customers? Customers { get; set; }
    public virtual product? Products { get; set; }  
    
    }
}
