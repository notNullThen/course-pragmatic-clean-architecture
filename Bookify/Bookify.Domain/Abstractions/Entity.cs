namespace Bookify.Domain.Abstractions;

internal abstract class Entity(Guid id)
{
    public Guid Id => id;
}
