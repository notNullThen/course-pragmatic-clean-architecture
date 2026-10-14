using Bookify.Domain.Apartments;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Bookings;

public class PricingService
{
    internal PricingDetails CalculatePrice(Apartment apartment, DateRange period)
    {
        var currency = apartment.Price.Currency;

        var priceForPeriod = new Money(apartment.Price.Amount * period.LengthInDays, currency);

        var percentageUpCharge = Percent.Zero();

        foreach (var amenity in apartment.Amenities)
        {
            percentageUpCharge += amenity switch
            {
                Amenity.GardenView or Amenity.MountainView => new Percent(5),
                Amenity.AirConditioning => new Percent(1),
                Amenity.Parking => new Percent(1),
                _ => Percent.Zero()
            };
        }

        var amenitiesUpCharge = Money.Zero(currency);

        if (percentageUpCharge.Percents > 0)
        {
            amenitiesUpCharge = new Money(percentageUpCharge.From(priceForPeriod.Amount), currency);
        }

        var totalPrice = Money.Zero(currency);

        totalPrice += priceForPeriod;

        if (!apartment.CleaningFee.IsZero())
        {
            totalPrice += apartment.CleaningFee;
        }

        totalPrice += amenitiesUpCharge;

        return new PricingDetails(priceForPeriod, apartment.CleaningFee, amenitiesUpCharge, totalPrice);
    }
}
