using AutoMapper;
using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using Ecommerce.Application.Features.OrderCancellation.Queries.GetAllOrderCancellation;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class OrderCancelationProfile : Profile
{
    public OrderCancelationProfile()
    {
        CreateMap<OrderCancelationDto, OrderCancelation>().ReverseMap();
        CreateMap<OrderCancelation, OrderCancelationDto>();
    }
}

