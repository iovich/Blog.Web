using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Data.Entities
{
    [Table("tblTags")]
    public class TagEntity : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string UrlSlug { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<PostTagEntity> PostTags { get; set; }
    }
}
