using Blog.Web.Data.Entities;
using System.Reflection.Metadata.Ecma335;

namespace Blog.Web.Models.Category
{
    public class CategoryItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<PostEntity> Posts { get; set; }

    }
}
