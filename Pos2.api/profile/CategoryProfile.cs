using AutoMapper;
using Pos2.entities;
using Pos2.Models;

namespace Pos2.api.profile
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryMapper>().ReverseMap();
            this.CreateMap<Category, CategoryCreateMapper>().ReverseMap();
            this.CreateMap<Category, CategoryUpdateMapper>().ReverseMap();
            this.CreateMap<Category, CategoryRemoveMapper>().ReverseMap();

        }
    }
}
