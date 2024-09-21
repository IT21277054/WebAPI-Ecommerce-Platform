using Ardalis.Result;
using Ardalis.SharedKernel;

namespace eCommerce_Backend_System.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
