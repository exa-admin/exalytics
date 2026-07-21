namespace Exalytics.Web.Services;

// ─────────────────────────────────────────────────────────────────────────────
// Read gating / metering for Topic Detail + Series Detail pages.
//
// Product rules:
//   • Guest users see preview only.
//   • Signed-in free users can read 5 distinct topic/series detail pages/month.
//   • Premium/admin users get full access.
//
// TODO(Phase 2):
//   Back this with Microsoft Entra ID and Azure SQL tables such as UserPlans,
//   AccessEntitlements, and UserContentReads.
//
// Razor components depend on this interface, so the UI should not change when
// the stub is replaced by real auth + database-backed usage tracking.
// ─────────────────────────────────────────────────────────────────────────────

public enum AccessLevel
{
    Full,
    GuestPreview,
    LimitReached
}

public sealed record AccessState(
    AccessLevel Level,
    bool IsSignedIn,
    bool IsPremium,
    int ReadsUsed,
    int ReadLimit)
{
    public bool IsUnlocked => Level == AccessLevel.Full;
    public bool IsLimited => Level == AccessLevel.LimitReached;
    public int ReadsRemaining => IsPremium ? int.MaxValue : Math.Max(ReadLimit - ReadsUsed, 0);
}

public interface IReadingAccessService
{
    AccessState Evaluate(string contentType, string slug);

    bool IsSignedIn { get; }

    bool IsPremium { get; }

    // Stub-only helpers. Real sign-in will be Microsoft Entra ID.
    void SignInDemo();

    void SignOutDemo();

    event Action? Changed;
}
