using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

public record GetInventoryDetailQuery(Guid Id) : IRequest<InventoryDetailDto>;
