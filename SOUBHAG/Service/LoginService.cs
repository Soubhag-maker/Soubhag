using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOUBHAG.Model;
using SOUBHAG.Repository;
using AutoMapper;
using SOUBHAG.Entity;

namespace SOUBHAG.Service
{
    public interface ILoginService
    {
        LoginModel Login(LoginModel model);
        Adm0001Model GetModules(int UserId);
        Adm0001Model GetSubModules(int menuId);
        Adm0001Model GetPagesList(int UserId);
    }
    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _LoginRepository;
        private readonly IMapper _mapper;

        public LoginService(ILoginRepository LoginRepository, IMapper mapper)
        {
            _mapper = mapper;
            _LoginRepository = LoginRepository;
        }


        public LoginModel Login(LoginModel model)
        {
            return _mapper.Map<LoginModel>(_LoginRepository.Login(_mapper.Map<LoginEntity>(model)));
        }
        public Adm0001Model GetModules(int UserId)
        {
            return _mapper.Map<Adm0001Model>(_LoginRepository.GetModules(UserId));
        }
        public Adm0001Model GetSubModules(int menuId)
        {
            return _mapper.Map<Adm0001Model>(_LoginRepository.GetSubModules(menuId));
        }
        public Adm0001Model GetPagesList(int UserId)
        {
            return _mapper.Map<Adm0001Model>(_LoginRepository.GetPagesList(UserId));
        }
    }
}



