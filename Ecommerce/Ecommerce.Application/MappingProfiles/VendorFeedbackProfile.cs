using AutoMapper;
using Ecommerce.Application.Features.VendorFeedback.Commands.AddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetAllAddVendorFeedback;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;
using Ecommerce.Domain;

namespace Ecommerce.Application.MappingProfiles;

public class VendorFeedbackProfile : Profile
{
    public VendorFeedbackProfile()
    {
        CreateMap<VendorFeedbackDto, VendorFeedback>().ReverseMap();
        CreateMap<VendorFeedbackDetailDto, VendorFeedback>().ReverseMap();
        CreateMap<CreateVendorFeedbackDto, VendorFeedback>();
    }
}

