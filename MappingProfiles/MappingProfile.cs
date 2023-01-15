using AutoMapper;
using BikeZilla.Controllers.Resources;
using BikeZilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ModelResource>();
        }
    }
}
