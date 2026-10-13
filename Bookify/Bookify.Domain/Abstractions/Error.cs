namespace Bookify.Domain.Abstractions;

internal record Error(string Code, string Name)
{
    internal static Error None = new(string.Empty, string.Empty);

    internal static Error NullValue = new("Error.NullValue", "Null value was provided");
}
