namespace Exalytics.Web.Services;

// ─────────────────────────────────────────────────────────────────────────────
// RAG question-answering for a topic. Stub now; wired to Azure later.
//
// TODO(Phase 2):
//   1. Embed the question with Azure OpenAI embeddings.
//   2. Vector-search approved TopicVectorChunks / DocumentChunk rows for the topic
//      using Azure SQL native vector search or Azure AI Search.
//   3. Send retrieved chunks + structured observations + question to the LLM with
//      a grounded prompt.
//   4. Return a grounded answer, citations, confidence, and retrieval metadata.
//
// Razor components depend on this interface, so the UI should not change when
// the stub is replaced by a real Azure SQL/vector-search implementation.
// ─────────────────────────────────────────────────────────────────────────────

public sealed record RagCitation(string Kind, string Detail);

public sealed record RagAnswer(
    string Answer,
    IReadOnlyList<RagCitation> Citations,
    string Confidence,
    IReadOnlyList<string> ContextItems);

public interface IRagService
{
    Task<RagAnswer> AskAsync(string topicSlug, string question, CancellationToken ct = default);
}
