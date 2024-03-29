﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.DataAccess.Paging;
using Entities;

namespace Business.Profiles
{
    public class SurveyMappingProfile : Profile
    {
        public SurveyMappingProfile()
        {
            CreateMap<Survey, CreateSurveyRequest>().ReverseMap();
            CreateMap<Survey, CreatedSurveyResponse>().ReverseMap();

            CreateMap<Survey, UpdateSurveyRequest>().ReverseMap();
            CreateMap<Survey, UpdatedSurveyResponse>().ReverseMap();

            CreateMap<Survey, DeleteSurveyRequest>().ReverseMap();
            CreateMap<Survey, DeletedSurveyResponse>().ReverseMap();

            CreateMap<Survey, GetSurveyRequest>().ReverseMap();
            CreateMap<Survey, GetSurveyResponse>().ReverseMap();


            CreateMap<Survey, GetListedSurveyResponse>().ReverseMap();
            CreateMap<Paginate<Survey>, Paginate<GetListedSurveyResponse>>().ReverseMap();
        }
    }
}
