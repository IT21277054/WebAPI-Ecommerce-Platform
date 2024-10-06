using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Features.VendorFeedback.Queries.GetVendorFeedbackDetail;
using MediatR;

namespace Ecommerce.Application.Features.Product.Queries.GetAllProducts;


public class GetProductHandler : IRequestHandler<GetProductQuery, List<ProductDto>>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;
    private readonly IVendorFeedbackRepository _vendorRepository;

    public GetProductHandler(IMapper mapper, IProductRepository productRepository, IVendorFeedbackRepository vendorRepository)
    {
        this._mapper = mapper;
        this._productRepository = productRepository;
        this._vendorRepository = vendorRepository;

    }

    public async Task<List<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var products = await _productRepository.GetAsync();
        var feedbacks = await _vendorRepository.GetAsync();

        // Convert products to DTOs and include feedbacks
        var data = products.Select(product => new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Category = product.Category,
            ImageUrl = product.ImageUrl,
            VendorId = product.VendorId,
            IsActivated = product?.IsActivated,

            // Filter and map feedbacks related to the product
            Feedback = feedbacks?
            .Where(f => f.ProductId == product.Id)  // Ensure productId is compared correctly
            .Select(fb => new VendorFeedbackDetailDto
            {
                Email = fb.Email,
                ProductId = fb.ProductId,
                Comment = fb.Comment,
                Rating = fb.Rating
            }).ToList()  // Convert to a list of feedback DTOs
        }).ToList();

        // Return list of DTO objects
        return data;
    }


}
