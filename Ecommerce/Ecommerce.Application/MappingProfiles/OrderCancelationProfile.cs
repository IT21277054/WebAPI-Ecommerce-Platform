using AutoMapper;
using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetOrderCancellationDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class OrderCancelationProfile : Profile
{
    public OrderCancelationProfile()
    {
        CreateMap<OrderCancelationDto, OrderCancelation>().ReverseMap();
        CreateMap<OrderCancelationDetailDto, OrderCancelation>().ReverseMap();
        CreateMap<CreateOrderDto, OrderCancelation>();
    }
}

