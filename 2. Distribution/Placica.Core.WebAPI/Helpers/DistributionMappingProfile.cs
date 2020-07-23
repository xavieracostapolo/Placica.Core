using AutoMapper;
using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;

namespace Placica.Core.WebAPI.Helpers
{
    public class DistributionMappingProfile : Profile
    {
        public DistributionMappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Dto.Calificacion, Model.Calificacion>().ReverseMap();
            CreateMap<Dto.Categoria, Model.Categoria>().ReverseMap();
            CreateMap<Dto.Cliente, Model.Cliente>().ReverseMap();
            CreateMap<Dto.Empresa, Model.Empresa>().ReverseMap();
            CreateMap<Dto.Pedido, Model.Pedido>().ReverseMap();
            CreateMap<Dto.PedidoDetalle, Model.PedidoDetalle>().ReverseMap();
            CreateMap<Dto.Producto, Model.Producto>().ReverseMap();
            CreateMap<Dto.Usuario, Model.LoginModel>().ReverseMap();
        }
    }
}