namespace Bookify.Domain.Bookings;

internal record DateRange
{
    private DateRange() { }

    internal DateOnly Start { get; init; }

    internal DateOnly End { get; init; }

    internal int LengthInDays => End.DayNumber - Start.DayNumber;

    internal static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ArgumentException("End date cannot be earlier than start date.");
        }
        return new DateRange
        {
            Start = start,
            End = end
        };
    }
}
