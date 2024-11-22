using SafiStay.Domain.Abstractions;

namespace SafiStay.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;