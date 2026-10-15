namespace Bookify.Domain.Shared;

public record Currency
{
    internal static readonly Currency None = new(string.Empty);
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");

    private Currency(string code) => Code = code;

    public string Code { get; init; }

    public static Currency FromCode(string code) =>
        All.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase)) ?? throw new ApplicationException($"The currency code \"{code}\" is invalid.");

    public static readonly IReadOnlyCollection<Currency> All = [Usd, Eur];
}
