﻿// ====================================================
// File: IOrderRepository.cs
// Description: Repository interface for handling order entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Order.Queries.GetVendorItems;
using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for Order entities
public interface IOrderRepository : IGenericRepository<Order, Guid>
{
    Task<List<GetVendorItemDto>> GetItemsByVendorId(Guid vendorId);
    Task<Items> UpdateItemsByItemId(Items updatedItemData);
    Task<Order> GenerateOrder(string email);
    Task<Order> GetOrderByEmail(string email);
    Task<Items> CancelItem(Guid itemId);
    Task<Items> UpdateItemStatus(Guid itemId);
}
