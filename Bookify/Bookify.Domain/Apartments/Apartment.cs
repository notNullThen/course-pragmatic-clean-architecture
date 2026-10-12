namespace Bookify.Domain.Apartments
{
    internal sealed class Apartment
    {
        public Guid Id;

        public string Name;

        public string Description;

        public string Country;

        public string State;

        public string ZipCode;

        public string City;

        public string Street;

        public decimal PriceAmount;

        public string PriceCurrency;

        public decimal CleaningFeeAmount;

        public string CleaningFeeCurrency;

        public DateTime? LastBookedOnUtc;

        public List<Amenity> Amenities;
    }
}
