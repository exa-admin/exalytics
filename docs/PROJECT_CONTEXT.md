# Project Context

Project name: Exalytics.

## One-Line Summary

A Microsoft-native economic data analytics platform that combines interactive topic dashboards with CMS-style notes and analysis.

## Product Goal

Create a web application where economists, analysts, students, and curious readers can explore macroeconomic topics through interactive charts, latest database-backed indicators, and written interpretation.

The first topic is Balance of Payments of India. The platform must later support many more topics, such as Trade Deficit of USA, India forex reserves, inflation, GDP growth, and sectoral trade analysis, without changing the core technology stack.

## Meaning of "Real Time"

In this project, "real time" means the frontend reads the latest data available in Azure SQL Database at the moment the page loads or refreshes. It does not mean calling IMF, RBI, World Bank, BEA, or other external providers directly from the browser on every page view.

External data can be imported separately by admin upload, Azure Functions, or later Azure Data Factory or Microsoft Fabric. Public pages should read from the application database.

## Target Users

- Economists checking how a topic is behaving over time.
- Analysts who want quick charts and latest indicators.
- Students learning how to interpret macroeconomic data.
- Readers who want clear written notes alongside data.
- The site owner, who needs CMS-style editing and topic management.

## Product Shape

The application should have these major public experiences:

1. Homepage: search, featured topics, latest data updates, latest analysis.
2. Topics: browse and filter all available economic topics.
3. Topic dashboard: interactive charts, key metrics, notes, methodology, sources, refresh context, and AI analyst-note timeline.
4. Series: chart-first individual indicators such as Inflation CPI, JOLTS job openings, unemployment, yields, oil, and FX.
5. Series detail: lightweight trend charts, bars, latest observations, source notes, and short explanation for one indicator.
6. Collaborate: proposal form where SMEs and partners can suggest new topic dashboards, series, or chart reuse.
7. Account and subscription: login, sign up, free plan, premium plan, and billing states.

The application should also have an admin experience:

1. Manage topics.
2. Manage indicators.
3. Upload or refresh observations.
4. Configure dashboard widgets.
5. Write and publish notes.
6. Review data refresh runs and validation warnings.
7. Review AI-generated analyst-note drafts before publishing.
8. Review submitted topic proposals from the collaborate page.

## AI Analyst Notes

Topic detail pages should end with an analyst-note section that reads like a blog post connected to the charts above it.

The note should be generated from Exalytics data stored in Azure SQL, not by calling external providers from the public page. The retrieval context should include observations, indicators, dimensions, source metadata, methodology notes, refresh logs, validation warnings, and prior analyst notes.

Every successful topic refresh can create a new analysis draft. The draft should be versioned, tied to the refresh run and data snapshot, and reviewed by a human before becoming public. Over time, this creates an analysis timeline for each topic.

## Topic RAG Agent

Every topic detail page should have a topic-specific RAG question panel where signed-in readers can ask follow-up questions about that topic.

Example question:

- "Why was India's balance of payments weak in Oct 2025?"

The answer should later be generated from Azure SQL-backed retrieval context, including vector chunks, indicator observations, source metadata, refresh runs, methodology notes, validation warnings, and prior analyst notes. The public page should not call external data providers directly when answering. It should query the application backend, which retrieves matching topic context and returns a cited answer.

For the MVP, the UI can show hardcoded mock answers and mock citations, but the code should keep clear seams for a future `RagAnswerService`, `TopicVectorChunks`, `RagQuestionRuns`, and citation records.

Current MVP service seam:

- `IRagService`.
- `StubRagService`.
- `TopicRagAgent.razor`.

Razor pages should call the component/service seam and should not hardcode RAG answers directly in page files.

## Free Access and Monthly Read Tracking

Topic detail pages and series detail pages should support a guest preview and signed-in full-read model.

- Guest users can preview the first part of a topic or series detail page.
- Signed-in free users can read 5 topic/series detail pages per month.
- Once the free monthly limit is reached, the full page should be locked until the next month or a future paid plan.
- Home, topics listing, series listing, and collaborate pages should remain browsable without this read gate unless product requirements change.

The MVP can use mock access state in Razor components. Later this should be backed by Microsoft Entra ID plus Azure SQL tables such as `UserContentReads`, `UserPlans`, and `AccessEntitlements`.

Current MVP service seam:

- `IReadingAccessService`.
- `StubReadingAccessService`.
- `AccessPreviewGate.razor`.

Razor pages should pass content identity such as topic/series slug into the gate. The service should decide whether the user gets full access, guest preview, or limit-reached state.

## Topic Details vs Series Details

Topic detail pages are deeper analytical dashboards. They combine KPI cards, dimension filters, multiple widgets, latest observations, refresh/RAG context, methodology/source notes, and a final AI analyst-note section.

Series detail pages are simpler chart-first pages for one indicator. They show compact metrics, a trend chart with bars, latest observations, source metadata, and a short trend explanation. They should not replace full topic pages.

## Core Product Rule

Do not build a one-off Balance of Payments page. Build a topic platform where Balance of Payments of India is the first configured topic.

## Current Preferences

- Microsoft-native full stack.
- JetBrains Rider as IDE. Do not assume Visual Studio as the development environment.
- Figma for design before implementation.
- Azure hosting.
- Flexible architecture for future topics.
- Design-first project flow.

## Documentation Map Additions

- `docs/DETAIL_PAGE_DESIGN.md`: design rules for topic detail pages, series detail pages, click behavior, and database-backed page shape.
