using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SOUBHAG.Entity;
using SOUBHAG.Model;

namespace SOUBHAG.Mapping
{
    public class LoginMappingProfile:Profile
    {
        public LoginMappingProfile()
        {
            CreateMap<LoginEntity, LoginModel>();
            CreateMap<LoginModel, LoginEntity>();

            CreateMap<adm0001Entity, Adm0001Model>();
            CreateMap<Adm0001Model, adm0001Entity>();
        }
    }
}
