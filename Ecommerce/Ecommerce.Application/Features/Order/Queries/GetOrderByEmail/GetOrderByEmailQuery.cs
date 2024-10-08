using Ecommerce.Application.Features.Order.Queries.GetOrdersDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Order.Queries.GetOrderByEmail;

public record GetOrderByEmailQuery(string email) : IRequest<OrderDetailDto>;