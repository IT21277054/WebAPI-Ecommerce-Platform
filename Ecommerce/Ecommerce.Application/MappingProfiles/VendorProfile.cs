using AutoMapper;
using Ecommerce.Application.Features.Vendor.Commands.CreateVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using Ecommerce.Application.Features.Vendor.Queries.GetVendorDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class VendorProfile : Profile
{
    public VendorProfile()
    {
        CreateMap<VendorDto, Vendor>().ReverseMap();
        CreateMap<VendorDetailDto, Vendor>().ReverseMap();
        CreateMap<CreateVendorDto, Vendor>();
    }
}

