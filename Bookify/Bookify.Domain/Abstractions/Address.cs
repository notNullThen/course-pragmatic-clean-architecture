namespace Bookify.Domain.Abstractions;

internal sealed record Address(string Country, string State, string ZipCode, string City, string Street);
