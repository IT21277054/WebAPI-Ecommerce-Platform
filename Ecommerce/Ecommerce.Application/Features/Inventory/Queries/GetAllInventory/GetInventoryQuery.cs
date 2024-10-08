// ====================================================
// File: GetInventoryQuery.cs
// Description: Query class for retrieving all inventory items.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using MediatR; // MediatR for handling requests and responses

namespace Ecommerce.Application.Features.Inventory.Queries.GetAllInventory;

// Query class for retrieving all inventory items, returns a list of InventoryDto
public record GetInventoryQuery : IRequest<List<InventoryDto>>;
