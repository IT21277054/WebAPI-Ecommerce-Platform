using AutoMapper;
using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class InventoryProfile : Profile
{
    public InventoryProfile()
    {
        CreateMap<InventoryDto, Inventory>().ReverseMap();
        CreateMap<CreateInventoryDto, Inventory>();
    }
}

