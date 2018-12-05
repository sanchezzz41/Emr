using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Emr.Database.Models;
using Emr.Domain.Accounts.Models;
using Emr.Domain.Drags.Models;
using Emr.Domain.Patients.Models;

namespace Emr.Domain
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //TODO тут подклчючается мапеер
            CreateMap<UserRegInfo, User>()
                .ForMember(dest => dest.UserGuid, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore());

            CreateMap<PatientInfo, Patient>();
            CreateMap<Patient, PatientModel>();

            CreateMap<DragInfo,Drag>();
            CreateMap<Drag, DragModel>();

        }
    }
}
