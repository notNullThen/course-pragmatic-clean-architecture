namespace Bookify.Domain.Shared;

internal sealed class Percent(int percents)
{
    internal int Percents => percents;
    internal decimal Percentage => percents / 100;

    internal decimal From(decimal amount) => amount * Percentage;
    internal decimal From(int amount) => amount * Percentage;

    public static Percent operator +(Percent a, Percent b) => new(a.Percents + b.Percents);

    internal static Percent Zero() => new(0);
}
