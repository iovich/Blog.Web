﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Data.Entities
{
    [Table("tblPosts")]
    public class PostEntity : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [StringLength(5000)]
        public string ShortDescription { get; set; }

        [StringLength(5000)]
        public string Description { get; set; }

        [Required, StringLength(1000)]
        public string Meta { get; set; }

        [Required, StringLength(200)]
        public string UrlSlug { get; set; }

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<PostTagEntity> PostTags { get; set; }
    }
}
