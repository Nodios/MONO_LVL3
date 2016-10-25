﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LVL3.Common.ViewModels;
using LVL3.Model;

namespace LVL3.MVC_test.App_Start
{
    public static class MappingConfig
    {

        public static void RegisterMaps()
        {
            Mapper.Initialize(config => 
            {
                config.CreateMap<VehicleMake, VehicleMakeViewModel>()
                .ForMember(dest => dest.VehicleMakeId, opt => opt.MapFrom(src => src.VehicleMakeId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Abrv, opt => opt.MapFrom(src => src.Abrv));

                config.CreateMap<VehicleMakeViewModel, VehicleMake>();

                config.CreateMap<VehicleModel, VehicleModelViewModel>()
                .ForMember(dest => dest.VehicleModelId, opt => opt.MapFrom(src => src.VehicleModelId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Abrv, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.VehicleMakeName, opt => opt.MapFrom(src => src.VehicleMake.Name));

                config.CreateMap<VehicleModelViewModel, VehicleModel>();

            });
        }


    }


}