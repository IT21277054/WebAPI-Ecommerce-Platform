// ====================================================
// File: InventoryProfile.cs
// Description: AutoMapper profile for mapping Inventory entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.Inventory.Commands.CreateInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;
using Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class InventoryProfile : Profile
{
    public InventoryProfile()
    {
        CreateMap<InventoryDto, Inventory>().ReverseMap();
        CreateMap<InventoryDetailDto, Inventory>().ReverseMap();
        CreateMap<CreateInventoryDto, Inventory>();
    }
}