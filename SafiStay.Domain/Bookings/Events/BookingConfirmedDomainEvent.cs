using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Bookings.Events;

public record BookingConfirmedDomainEvent(Guid BookingId): IDomainEvent;