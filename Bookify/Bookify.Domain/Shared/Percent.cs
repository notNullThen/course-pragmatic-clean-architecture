namespace Bookify.Domain.Shared;

internal sealed class Percent(int percents)
{
    public int Percents => percents;
    public decimal Percentage => percents / 100;

    public decimal From(decimal amount) => amount * Percentage;
    public decimal From(int amount) => amount * Percentage;

    public static Percent operator +(Percent a, Percent b) => new(a.Percents + b.Percents);

    internal static Percent Zero() => new(0);
}
