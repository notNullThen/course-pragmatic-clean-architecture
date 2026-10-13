using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews;

internal sealed record Rating
{
    internal static readonly Error Invalid = new("Rating.Invalid", "The rating is invalid");

    private Rating(int value) => Value = value;

    internal int Value { get; init; }

    internal static Result<Rating> Create(int value)
    {
        if (value < 1 || value > 5)
        {
            return Result.Failure<Rating>(Invalid);
        }

        return new Rating(value);
    }
}