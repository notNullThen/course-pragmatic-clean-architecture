namespace Bookify.Domain.Apartments;

internal sealed record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException($"Cannot add different currencies amounts: {first.Currency.Code} and {second.Currency.Code}.");
        }

        return new Money(first.Amount + second.Amount, first.Currency);
    }

    internal static Money Zero() => new(0, Currency.None);
    internal static Money Zero(Currency currency) => new(0, currency);

    public bool IsZero() => this == Zero(Currency);
}
