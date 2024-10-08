using Ecommerce.Application.Features.Product.Queries.GetAllProducts;
using Ecommerce.Application.Features.Product.Queries.GetProductDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Queries.GetProductByCategory;

public record GetProductByCategoryQuery(string catogery) : IRequest<List<ProductDto>>;