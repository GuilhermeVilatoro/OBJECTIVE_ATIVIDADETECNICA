﻿using AutoMapper;

namespace AtividadeTecnica.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToBusinessDtoMappingProfile>();
            });
        }

        public static void ResetMappings()
        {
            Mapper.Reset();
        }
    }
}