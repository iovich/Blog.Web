using Blog.Web.Models.Category;
using Blog.Web.Models.Tag;

namespace Blog.Web.Models.Post
{
    public class PostItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }
        //public int CategoryId { get; set; } // Додайте інші необхідні властивості
        public CategoryItemViewModel Category { get; set; }
        public ICollection<TagItemViewModel> Tags { get; set; }

    }
}
