using Ecommerce.Application.Features.Category.Queries.GetAllCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Queries.GetCategoryDetails;

public record GetCategoryDetailsQuery(int Id) : IRequest<CatgoryDetailsDto>;
