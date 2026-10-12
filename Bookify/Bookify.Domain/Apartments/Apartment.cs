using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments
{
    internal sealed class Apartment(Guid id) : Entity(id)
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public Address Address { get; private set; }

        public Money Price { get; private set; }

        public Money CleaningFee { get; private set; }

        public DateTime? LastBookedOnUtc { get; private set; }

        public List<Amenity> Amenities { get; private set; }
    }
}
