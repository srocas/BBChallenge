using AutoMapper;
using BBApplication.DTOs;
using BBDomain.Entities;

namespace BBApi
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, CategoryDTO>();

            CreateMap<SubCategoryDTO, SubCategory>();
            CreateMap<SubCategory, SubCategoryDTO>();

            CreateMap<InteriorCategoryDTO, InteriorCategory>();
            CreateMap<InteriorCategory, InteriorCategoryDTO>();

            CreateMap<PostDTO, Post>();
            CreateMap<Post, PostDTO>();

            CreateMap<PostCategoryDTO, PostCategory>();
            CreateMap<PostCategory, PostCategoryDTO>()
                .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category.Name))
                .ForMember(dest => dest.SubCategory, src => src.MapFrom(x => x.SubCategory.Name))
                .ForMember(dest => dest.InteriorCategory, src => src.MapFrom(x => x.InteriorCategory.Name));
        }
    }
}
