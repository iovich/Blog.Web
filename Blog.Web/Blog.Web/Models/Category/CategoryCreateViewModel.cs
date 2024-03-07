using Blog.Web.Data.Entities;

namespace Blog.Web.Models.Category
{
    public class CategoryCreateViewModel
    {
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PostEntity> Posts { get; set; }

    }
}
