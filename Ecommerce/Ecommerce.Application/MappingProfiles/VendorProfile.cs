using AutoMapper;
using Ecommerce.Application.Features.Vendor.Queries.GetAllVendor;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class VendorProfile : Profile
{
    public VendorProfile()
    {
        CreateMap<VendorDto, Vendor>().ReverseMap();
        CreateMap<Vendor, VendorDto>();
    }
}

