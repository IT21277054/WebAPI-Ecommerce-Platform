// ====================================================
// File: DeleteInventoryHandler.cs
// Description: Handler for deleting an inventory item by its ID.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using AutoMapper;
using Ecommerce.Application.Contracts.Persistence;
using MediatR;

namespace Ecommerce.Application.Features.Inventory.Commands.DeleteInventory
{
    public class DeleteInventoryHandler : IRequestHandler<DeleteInventoryCommand, Unit>
    {
        private readonly IMapper _mapper; // AutoMapper for mapping between DTO and domain entities
        private readonly IInventoryRepository _inventoryRepository; // Repository for inventory operations

        public DeleteInventoryHandler(IMapper mapper, IInventoryRepository inventoryRepository)
        {
            this._mapper = mapper;
            this._inventoryRepository = inventoryRepository;
        }

        public async Task<Unit> Handle(DeleteInventoryCommand request, CancellationToken cancellationToken)
        {
            // Retrieve the inventory entity to delete
            var inventoryToDelete = await _inventoryRepository.GetByIdAsync(request.Id);

            // Validate if the inventory exists (optional)

            // Delete the inventory from the database
            await _inventoryRepository.DeleteAsync(inventoryToDelete);

            // Return a success response
            return Unit.Value;
        }
    }
}
