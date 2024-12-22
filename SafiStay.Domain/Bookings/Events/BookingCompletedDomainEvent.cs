using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Bookings.Events;

public record BookingCompletedDomainEvent(Guid BookingId): IDomainEvent;