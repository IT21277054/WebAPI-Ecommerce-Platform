using Ardalis.Result;
using Ardalis.SharedKernel;

namespace eCommerce_Backend_System.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
