using AutoMapper;
using Blog.Web.Data.Entities;
using Blog.Web.Models.Category;
using Blog.Web.Models.Tag;

namespace Blog.Web.Mapper
{
    public class AppUIMapper : Profile
    {
        public AppUIMapper()
        {
            //CreateMap<CategoryEntity, CategoryItemViewModel>();
            CreateMap<TagEntity, TagItemViewModel>();
        }
        
    }
}
