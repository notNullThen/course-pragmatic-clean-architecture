using Bookify.Domain.Abstractions;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Apartments;

internal sealed class Apartment(
    Guid id,
    Name name,
    Description description,
    Address address,
    Money price,
    Money cleaningFee,
    DateTime? lastBookedOnUtc,
    List<Amenity> amenities)
    : Entity(id)
{
    internal Name Name { get; private set; } = name;

    internal Description Description { get; private set; } = description;

    internal Address Address { get; private set; } = address;

    internal Money Price { get; private set; } = price;

    internal Money CleaningFee { get; private set; } = cleaningFee;

    internal DateTime? LastBookedOnUtc { get; set; } = lastBookedOnUtc;

    internal List<Amenity> Amenities { get; private set; } = amenities;
}
