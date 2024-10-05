using MediatR;

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

public record GetInventoryDetailQuery(int Id) : IRequest<InventoryDetailDto>;
