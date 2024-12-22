using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Bookings.Events;

public record BookingCanceledDomainEvent(Guid BookingId): IDomainEvent;