using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Modals;
using TaskApi.Services.ViewModels;

namespace TaskApi.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}"));
        }
    }
}
