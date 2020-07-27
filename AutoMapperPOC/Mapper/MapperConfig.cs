using System;
using AutoMapper;
using Models;

namespace Mapper
{
    class MapperConfig
    {
        public static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Sword, SwordDTO>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
