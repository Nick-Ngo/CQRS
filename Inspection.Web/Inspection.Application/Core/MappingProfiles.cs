using AutoMapper;
using Inspection.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspection.Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
            CreateMap<Category, Category>();
        }
    }
}
