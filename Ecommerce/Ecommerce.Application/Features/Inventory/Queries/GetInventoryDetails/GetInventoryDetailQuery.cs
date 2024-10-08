// ====================================================
// File: GetInventoryDetailQuery.cs
// Description: Query class for retrieving details of a specific inventory item.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;

// Query class for retrieving details of a specific inventory item, returning an InventoryDetailDto
public record GetInventoryDetailQuery(Guid Id) : IRequest<InventoryDetailDto>;
