// ====================================================
// File: VendorFeedbackProfile.cs
// Description: AutoMapper profile for mapping VendorFeedback entities to their corresponding DTOs and vice versa.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

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
        // Map VendorFeedbackDto to VendorFeedback and vice versa
        CreateMap<VendorFeedbackDto, VendorFeedback>().ReverseMap();

        // Map VendorFeedbackDetailDto to VendorFeedback and vice versa
        CreateMap<VendorFeedbackDetailDto, VendorFeedback>().ReverseMap();

        // Map CreateVendorFeedbackDto to VendorFeedback
        CreateMap<CreateVendorFeedbackDto, VendorFeedback>();
    }
}
