using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Data.Entities
{
    [Table("tblPostTags")]
    public class PostTagEntity : BaseEntity<int>
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }

        public virtual PostEntity Post { get; set; }
        public virtual TagEntity Tag { get; set; }
    }
}
