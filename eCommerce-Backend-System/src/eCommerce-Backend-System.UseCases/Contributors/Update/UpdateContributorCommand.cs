using Ardalis.Result;
using Ardalis.SharedKernel;

namespace eCommerce_Backend_System.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
