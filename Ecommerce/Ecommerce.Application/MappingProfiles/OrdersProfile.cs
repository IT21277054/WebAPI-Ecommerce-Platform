using AutoMapper;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class OrdersProfile : Profile
{
    public OrdersProfile()
    {
        CreateMap<OrderDto, Order>().ReverseMap();
        CreateMap<CreateOrderDto, Order>();
    }
}

