using SafiStay.Domain.Apartments;

namespace SafiStay.Domain.Shared;

public sealed record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException("Cannot add different currencies.");
        }

        return new Money(first.Amount + second.Amount, first.Currency);
    }
    public static Money Zero() => new (0, Currency.None);
    public static Money Zero(Currency currency) => new Money(0, currency);
    public bool IsZero() => this == Zero(Currency);
}