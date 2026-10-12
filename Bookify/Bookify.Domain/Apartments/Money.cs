namespace Bookify.Domain.Apartments
{
    internal sealed class Money(decimal amount, string currency)
    {
        public decimal Amount => amount;

        public string Currency => currency;
    }
}
