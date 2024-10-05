using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.DeleteOrderCancellation;

public class DeleteOrderCancellationCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
