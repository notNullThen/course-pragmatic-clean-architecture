using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

internal record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;