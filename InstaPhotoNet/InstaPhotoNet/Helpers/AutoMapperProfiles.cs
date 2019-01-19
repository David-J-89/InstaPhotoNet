﻿using AutoMapper;
using InstaPhotoNet.Dtos;
using InstaPhotoNet.Models;
using System.Linq;

namespace InstaPhotoNet.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                    .ForMember(dest => dest.PostUrl, opt =>
                    {
                        opt.MapFrom(src => src.Posts.FirstOrDefault(p => p.IsProfile).Url);
                    });

            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PostUrl, opt =>
                {
                    opt.MapFrom(src => src.Posts.FirstOrDefault(p => p.IsProfile).Url);
                });


            CreateMap<PostsForDetailedDto, Post>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<PostForReturnDto, Post>();
            CreateMap<PostForCreationDto, Post>();
            ;
        }
    }
}