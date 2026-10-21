using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;

internal abstract class Repository<T>(ApplicationDbContext dbContext)
    where T : Entity
{
    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await dbContext
            .Set<T>()
            .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);

    public void Add(T entity)
    {
        dbContext.Add(entity);
    }
}
