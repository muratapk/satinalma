using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace satinalma.Models
{
    public class categories
    {
        [Key]
        public int ? category_id { get;set; }
        public string name { get; set; } = string.Empty;
        virtual public ICollection<product>? products { get; set; }
    }
}
