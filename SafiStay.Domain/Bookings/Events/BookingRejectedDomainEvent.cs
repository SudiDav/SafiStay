using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId): IDomainEvent;