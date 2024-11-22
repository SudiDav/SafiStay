using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId): IDomainEvent;