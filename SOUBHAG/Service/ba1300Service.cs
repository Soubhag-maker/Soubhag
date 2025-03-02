using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOUBHAG.Model;
using SOUBHAG.Repository;
using AutoMapper;

namespace SOUBHAG.Service
{
    public interface Iba1300Service
    {
        ba1300Model LoadFind();
    }
    public class ba1300Service : Iba1300Service
    {

        private readonly Iba1300Repository _ba1300Repository;
        private readonly IMapper _mapper;

        public ba1300Service(Iba1300Repository ba1300Repository, IMapper mapper)
        {
            _mapper = mapper;
            _ba1300Repository = ba1300Repository;
        }


        public ba1300Model LoadFind()
        {
            return _mapper.Map<ba1300Model>(_ba1300Repository.LoadFind());
        }
    }
}



