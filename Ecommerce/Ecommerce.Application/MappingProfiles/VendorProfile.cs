// ====================================================
// File: VendorProfile.cs
// Description: AutoMapper profile for mapping Vendor entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using AutoMapper;
using Ecommerce.Application.Features.Vendor.Commands.CreateVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetVendorDetailQuery;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class VendorProfile : Profile
{
    public VendorProfile()
    {
        // Map VendorDto to Vendor and vice versa
        CreateMap<VendorDto, Vendor>().ReverseMap();

        // Map VendorDetailDto to Vendor and vice versa
        CreateMap<VendorDetailDto, Vendor>().ReverseMap();

        // Map CreateVendorDto to Vendor
        CreateMap<CreateVendorDto, Vendor>();
    }
}
