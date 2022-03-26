using AirlineProject.Application.ViewModels.CampaingViewModels;
using AirlineProject.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.Mapping
{
    class CommonMappingProfile : Profile
    {
        public CommonMappingProfile()
        {
            CreateMap<CampaingQueryViewModel, Campaing>().ReverseMap();
            CreateMap<CampaingCommandViewModel, Campaing>().ReverseMap();
            CreateMap<InformationQueryViewModel, Information>().ReverseMap();
            CreateMap<InformationCommandViewModel, Information>().ReverseMap();
        }
    }
}
