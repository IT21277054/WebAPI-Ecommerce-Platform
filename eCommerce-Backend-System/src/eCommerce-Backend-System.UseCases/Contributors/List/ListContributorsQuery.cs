using Ardalis.Result;
using Ardalis.SharedKernel;

namespace eCommerce_Backend_System.UseCases.Contributors.List;

public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
