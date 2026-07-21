namespace Exalytics.Web.Services;

/// <summary>
/// Hardcoded demo implementation. Later this becomes the Azure SQL/vector-search
/// retrieval service for topic-specific Q&A.
/// </summary>
public sealed class StubRagService : IRagService
{
    public async Task<RagAnswer> AskAsync(string topicSlug, string question, CancellationToken ct = default)
    {
        // Simulate embed → vector search → grounded answer latency.
        await Task.Delay(450, ct);

        var normalizedQuestion = question.ToLowerInvariant();

        if (topicSlug == "india-balance-of-payments" &&
            (normalizedQuestion.Contains("oct") ||
             normalizedQuestion.Contains("2025") ||
             normalizedQuestion.Contains("bad") ||
             normalizedQuestion.Contains("weak") ||
             normalizedQuestion.Contains("deficit") ||
             normalizedQuestion.Contains("current account")))
        {
            return new RagAnswer(
                "India's current account looked weaker through late 2025 because goods imports grew faster than goods exports, widening the merchandise gap. The services surplus still absorbed a meaningful part of that pressure, so the external position looked manageable rather than crisis-like. In the current mock snapshot, Q4 2025 current account deficit is about -$10.5B, or roughly 1.2% of GDP.",
                [
                    new RagCitation("Observation", "Q4 2025 current account: -$10.5B, around 1.2% of GDP"),
                    new RagCitation("Observation", "Goods imports +4.8% q/q versus goods exports +3.1% q/q"),
                    new RagCitation("Source note", "RBI Balance of Payments release, Q4 2025 mock source note")
                ],
                "High demo confidence",
                [
                    "8 indicators",
                    "44 observations",
                    "3 source notes",
                    "1 refresh run",
                    "2 prior analyst notes"
                ]);
        }

        return new RagAnswer(
            $"Demo answer: once Azure is connected, Exalytics will vector-search this topic's approved observations, source notes, methodology and prior analyst notes for “{question}”, then return a grounded answer with citations.",
            [new RagCitation("Info", "Vector search is not connected yet — stub response")],
            "Demo",
            [
                "TopicVectorChunks pending",
                "Source metadata pending",
                "Refresh logs pending"
            ]);
    }
}
