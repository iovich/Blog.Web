using AutoMapper;
using Blog.Web.Data.Entities;
using Blog.Web.Models.Category;
using Blog.Web.Models.Post;
using Blog.Web.Models.Tag;

namespace Blog.Web.Mapper
{
    public class AppUIMapper : Profile
    {
        public AppUIMapper()
        {



            //CreateMap<CategoryEntity, CategoryItemViewModel>();
            //CreateMap<PostEntity, PostItemViewModel>();
            //CreateMap<TagEntity, TagItemViewModel>();
            //CreateMap<CategoryEntity, CategoryCreateViewModel>();
            //CreateMap<CategoryCreateViewModel, PostEntity>()
            //.ForMember(dest => dest.Id, opt => opt.Ignore()) // Ігноруємо Id, оскільки він буде генеруватися автоматично
            //.ForMember(dest => dest.PostedOn, opt => opt.MapFrom(src => DateTime.UtcNow)) // Призначте PostedOn поточну дату та час
            //.ForMember(dest => dest.Modified, opt => opt.Ignore()); // Ігноруємо Modified, оскільки він не заповнюється при створенні
            
            CreateMap<CategoryEntity, CategoryItemViewModel>();
            CreateMap<TagEntity, TagItemViewModel>();
            CreateMap<PostEntity, PostItemViewModel>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.PostTags.Select(pt => pt.Tag).ToList()));



        }

    }
}
