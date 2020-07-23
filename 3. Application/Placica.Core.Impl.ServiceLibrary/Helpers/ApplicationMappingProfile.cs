using AutoMapper;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.Helpers
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Dto.Calificacion, Entity.Calificacion>().ReverseMap();
            CreateMap<Dto.Categoria, Entity.Categoria>().ReverseMap();
            CreateMap<Dto.Cliente, Entity.Cliente>().ReverseMap();
            CreateMap<Dto.Empresa, Entity.Empresa>().ReverseMap();
            CreateMap<Dto.Pedido, Entity.Pedido>().ReverseMap();
            CreateMap<Dto.PedidoDetalle, Entity.PedidoDetalle>().ReverseMap();
            CreateMap<Dto.Producto, Entity.Producto>().ReverseMap();
            CreateMap<Dto.Usuario, Entity.Usuario>().ReverseMap();
        }
    }
}