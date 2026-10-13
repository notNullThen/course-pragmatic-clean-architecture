namespace Bookify.Domain.Shared;

internal record Currency
{
    internal static readonly Currency None = new(string.Empty);
    internal static readonly Currency Usd = new("USD");
    internal static readonly Currency Eur = new("EUR");

    private Currency(string code) => Code = code;

    internal string Code { get; init; }

    internal static Currency FromCode(string code) =>
        All.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase)) ?? throw new ApplicationException($"The currency code \"{code}\" is invalid.");

    internal static readonly IReadOnlyCollection<Currency> All = [Usd, Eur];
}
