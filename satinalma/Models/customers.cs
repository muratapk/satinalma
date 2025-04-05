using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace satinalma.Models
{
    public class customers
    {
        [Key]
        public int customer_id { get;set; }
        [Display(Name ="Adınız ")]
        [Required(ErrorMessage ="Boş Geçilemez")]
        public string first_name { get; set; } = string.Empty;
        [Display(Name ="Soyadınız")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string last_name { get; set; }=string.Empty;
        [Display(Name = "Email Adresiniz")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string email { get; set; } = string.Empty;
        [Display(Name = "Telefonu")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string phone { get; set; } = string.Empty;
        [Display(Name = "Şifresiz")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string password_hash { get; set; } = string.Empty;
        [Display(Name = "Alış Veriş Adresi")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string shipping_address { get; set; } = string.Empty;

        [Display(Name = "Fatura Adresi")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string billing_address { get; set; } = string.Empty;
        public virtual ICollection<product_reviews>? reviews { get; set; }
        public virtual ICollection<cart>? Carts { get; set; }    
    }
}
