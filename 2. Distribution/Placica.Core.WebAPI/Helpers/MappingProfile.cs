using AutoMapper;
using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.WebAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Model.Producto, Dto.Producto>();
            CreateMap<Dto.Producto, Entity.Producto>();
            CreateMap<Entity.Producto, Dto.Producto>();
            CreateMap<Dto.Producto, Model.Producto>();
        }
    }
}