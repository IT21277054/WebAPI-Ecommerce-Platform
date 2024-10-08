// ====================================================
// File: OrderCancelationProfile.cs
// Description: AutoMapper profile for mapping OrderCancelation entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
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