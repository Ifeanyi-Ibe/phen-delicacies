using PhenDelicacies.Application.Common.Interfaces;

namespace PhenDelicacies.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
