using Bookify.Domain.Shared;

namespace Bookify.Domain.Bookings;

internal record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);
