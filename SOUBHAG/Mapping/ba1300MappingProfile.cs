using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SOUBHAG.Entity;
using SOUBHAG.Model;

namespace SOUBHAG.Mapping
{
    public class ba1300MappingProfile:Profile
    {
        public ba1300MappingProfile()
        {
            CreateMap<ba1300Entity, ba1300Model>();
            CreateMap<ba1300Model, ba1300Entity>();
        }
    }
}
