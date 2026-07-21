# Detail Page Design

## Purpose

Exalytics has two different detail-page patterns:

- Topic detail pages: deep analytical dashboards for one economic topic.
- Series detail pages: lightweight chart-first pages for one indicator or time series.

Both patterns should be database-backed by Azure SQL through the application backend. Public pages should read the latest approved data snapshot from the database, not call external data providers directly from the browser.

## Topic Detail Pages

Example route:

- `/topics/india-balance-of-payments`

Example source files:

- `src/Exalytics.Web/Components/Pages/TopicDetails/IndiaBalanceOfPayments.razor`
- `src/Exalytics.Web/Components/Pages/TopicDetails/IndiaBalanceOfPayments.razor.css`

Topic detail pages are unique per topic and may have their own Razor page and isolated CSS file when the topic needs a custom layout.

The current Balance of Payments design pattern is:

1. Top KPI metric cards.
2. `Explore dimensions` filter panel.
3. Main chart widget plus latest refresh/RAG context panel.
4. Topic RAG analyst panel for signed-in follow-up questions.
5. Guest/sign-in access gate.
6. Supporting widget row:
   - Goods vs services balance.
   - Component contribution.
   - Latest observations.
7. AI analyst note section at the end of the page.
8. Analysis timeline beside the generated note.

Guest readers should see the top preview section first. The deeper widgets, full AI analyst note, and full RAG answer flow should require sign-in.

The AI analyst note should always appear near the end of the topic page, after the reader has seen the data context. It should be tied to:

- `TopicNotes`.
- `TopicDataSnapshots`.
- `DataRefreshRuns`.
- source metadata.
- methodology notes.
- prior analyst notes.

Draft AI notes require human review before publishing.

### Topic RAG Agent Pattern

Every topic detail page should reserve space for a topic-specific RAG agent.

For the MVP this uses `IRagService` with `StubRagService`. The Razor component should call the service interface, not embed RAG answer logic directly in the page.

The component should still be designed around the future production flow:

1. User signs in.
2. User asks a topic-specific question.
3. Backend validates the user's monthly read/access entitlement.
4. Backend retrieves relevant Azure SQL vector chunks and structured topic data.
5. Backend returns an answer with citations.
6. UI displays answer text, citations, and retrieval-context metadata.

The RAG context should come from topic data stored in Azure SQL, not direct browser calls to outside providers.

## Series Detail Pages

Example routes:

- `/series/inflation-cpi`
- `/series/jolts-job-openings`
- `/series/unemployment-rate`

Example source files:

- `src/Exalytics.Web/Components/Pages/SeriesDetails/SeriesDetail.razor`
- `src/Exalytics.Web/Components/Pages/SeriesDetails/SeriesDetail.razor.css`

Series detail pages are chart-first. They should be simpler than topic pages.

The current series detail design pattern is:

1. Series hero with title, category, source, unit, frequency, and last database refresh.
2. Compact filter strip.
3. Metric cards.
4. Main trend chart with observation bars.
5. Latest observation list.
6. Guest/sign-in access gate.
7. Short trend explanation.
8. Note explaining how a series differs from a full topic page.

Series pages should not duplicate full topic-dashboard behavior. If a reader needs multi-indicator explanation, methodology, AI analyst-note timeline, and source narrative, they should move from Series into Topics.

## Access Gate Pattern

Topic detail pages and series detail pages should use a shared access-gate component.

For the MVP this uses `IReadingAccessService` with `StubReadingAccessService`. Razor pages should pass only content identity such as `ContentKind` and `ContentSlug`; they should not contain hardcoded `IsSignedIn` or monthly-read constants.

Required behavior:

- Guests see a useful preview but not the complete page.
- Signed-in free users can read 5 topic/series detail pages per calendar month.
- The access gate should show a sign-in call to action and explain the free monthly read allowance.
- The public listing pages should remain ungated.

Future backing services:

- Microsoft Entra ID for user identity.
- Azure SQL `UserContentReads` or equivalent monthly usage tracking.
- `UserPlans` / `AccessEntitlements` for free vs paid access.

## Click Behavior

Cards should be clickable where possible:

- Topic listing cards should open topic detail pages.
- Featured topic cards on the homepage should open topic detail pages when a detail page exists.
- Series listing cards should open `/series/{slug}`.
- Preview/planned cards can still route to the library or a placeholder detail page, but should not silently do nothing.

## Database Shape

Topic detail pages are primarily driven by:

- `Topics`.
- `Indicators`.
- `Observations`.
- `DashboardWidgets`.
- `TopicFilterDefinitions`.
- `TopicNotes`.
- `DataSources`.
- `DataRefreshRuns`.
- `TopicDataSnapshots`.
- `TopicVectorChunks`.
- `RagQuestionRuns`.
- `AnalysisCitations`.
- `UserContentReads`.

Series detail pages are primarily driven by:

- a series slug or indicator slug.
- `Indicators`.
- `Observations`.
- source metadata.
- latest refresh status.
- lightweight chart configuration.
- `UserContentReads`.

## Styling Rule

Every page/detail component should keep its CSS isolated:

- `SomePage.razor`
- `SomePage.razor.css`

Global styles should stay limited to tokens, resets, and shared button primitives in `wwwroot/app.css`.
