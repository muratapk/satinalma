using System.ComponentModel.DataAnnotations;

namespace satinalma.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int ? ProductId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public virtual product? Product { get; set; }    

    }
}
