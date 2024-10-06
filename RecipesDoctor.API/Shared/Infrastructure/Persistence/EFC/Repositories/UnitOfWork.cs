using RecipesDoctor.API.Shared.Domain.Repositories;
using RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync() => await context.SaveChangesAsync();
}