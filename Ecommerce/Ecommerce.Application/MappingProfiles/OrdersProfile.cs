// ====================================================
// File: OrdersProfile.cs
// Description: AutoMapper profile for mapping Order entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.Order.Commands.CreateOrder;
using Ecommerce.Application.Features.Order.Queries.GetAllOrders;
using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using Ecommerce.Application.Features.Order.Queries.GetVendorItems;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class OrdersProfile : Profile
{
    public OrdersProfile()
    {
        CreateMap<OrderDto, Order>().ReverseMap();
        CreateMap<OrderDetailDto, Order>().ReverseMap();
        CreateMap<CreateOrderDto, Order>();
        CreateMap<ItemsDto, Items>().ReverseMap();
        CreateMap<GetVendorItemDto, Items>().ReverseMap();
    }
}