namespace Exalytics.Web.Services;

/// <summary>
/// In-memory demo implementation. Signed out by default. Later this becomes the
/// Entra ID + Azure SQL read-metering implementation.
/// </summary>
public sealed class StubReadingAccessService : IReadingAccessService
{
    public const int FreeMonthlyLimit = 5;

    private readonly HashSet<string> _readThisMonth = [];

    public bool IsSignedIn { get; private set; }

    public bool IsPremium { get; private set; }

    public event Action? Changed;

    public AccessState Evaluate(string contentType, string slug)
    {
        var key = $"{contentType}:{slug}";

        if (!IsSignedIn)
        {
            return new AccessState(AccessLevel.GuestPreview, false, false, _readThisMonth.Count, FreeMonthlyLimit);
        }

        if (IsPremium)
        {
            return new AccessState(AccessLevel.Full, true, true, _readThisMonth.Count, FreeMonthlyLimit);
        }

        if (!_readThisMonth.Contains(key) && _readThisMonth.Count >= FreeMonthlyLimit)
        {
            return new AccessState(AccessLevel.LimitReached, true, false, _readThisMonth.Count, FreeMonthlyLimit);
        }

        _readThisMonth.Add(key);
        return new AccessState(AccessLevel.Full, true, false, _readThisMonth.Count, FreeMonthlyLimit);
    }

    public void SignInDemo()
    {
        IsSignedIn = true;
        Changed?.Invoke();
    }

    public void SignOutDemo()
    {
        IsSignedIn = false;
        IsPremium = false;
        _readThisMonth.Clear();
        Changed?.Invoke();
    }
}
