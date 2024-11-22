using SafiStay.Domain.Apartments;
using SafiStay.Domain.Shared;

namespace SafiStay.Domain.Bookings;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice); 