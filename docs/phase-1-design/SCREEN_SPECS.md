# Screen Specs

## Homepage

Purpose:

Help users find topics and understand what changed recently.

Core sections:

- Header navigation.
- Search and discovery area.
- Featured topics.
- Latest data updates.
- Latest analysis notes.
- Topic explorer filters.

Public navigation:

- Home.
- Topics.
- Analysis.
- Collaborate.

Desktop layout:

- Fixed-width content area around 1200px to 1320px.
- Header at top.
- Search area directly below header.
- Featured topics in a responsive grid.
- Latest data updates and latest analysis as side-by-side sections.
- Topic explorer below.

Mobile layout:

- Collapsed navigation.
- Search first.
- Featured topics stacked.
- Latest updates before latest analysis.
- Filters collapse into controls.

## Topics Listing

Purpose:

Let users browse all available dashboards.

Core sections:

- Page title and short description.
- Search.
- Filters: country/region, category, frequency, data type.
- Topic result cards.
- Empty state.
- Collaborate banner for experts who want to suggest topics or data sources.

Topic card fields:

- Topic title.
- Country or region.
- Category.
- Latest period.
- One key metric.
- Last database update timestamp.
- Data status: live, preview, draft, planned, or collaborate.

Current high-fidelity frame:

- Figma node: `20:74`
- Design name: `Topics / Desktop High Fidelity`

## Topic Dashboard

Purpose:

Provide interactive data, context, and notes for one economic topic.

Use Balance of Payments of India as the first design example.

Current high-fidelity frame:

- Figma node: `41:2`
- Design name: `Topic Detail / India BOP Desktop High Fidelity`

Core sections:

- Breadcrumb.
- Topic header.
- Source, unit, frequency, latest period, and last database update.
- Metric tile row.
- Filter bar.
- Main chart.
- Secondary charts.
- Latest-observations table.
- Refresh insight panel.
- AI analyst note.
- Methodology and source details.

Key controls:

- Date range selector.
- Topic-specific dimension filters, such as goods/services, component, flow, country, sector, or unit.
- Unit selector where useful.
- Chart legend toggles.
- Download data button.

Design rule:

Every topic can have different controls and charts, but the page should use the same platform pattern: `DashboardWidgets` define the chart or metric, `FilterConfigJson` defines the controls, and observations/dimensions provide the data.

Metric tiles for first topic:

- Current account balance.
- Goods exports.
- Goods imports.
- Services exports.
- Services imports.
- Current account as percent of GDP.

AI analyst note behavior:

- The AI analyst note sits after the charts as a readable blog-style interpretation.
- The note is generated from database-backed context, not from live external websites.
- Retrieval context should include observations, indicators, dimensions, source metadata, methodology notes, refresh logs, validation warnings, and prior analyst notes.
- Each data refresh can produce a new draft note version.
- Draft AI notes should require human review before public publishing.
- Published notes should remain attached to the topic and build an analysis timeline over time.

## Analysis Note Page

Purpose:

Allow CMS-written analysis to live as readable article content connected to dashboards.

Core sections:

- Title.
- Topic link.
- Published date.
- Author.
- Summary.
- Main note content.
- Related charts or metric callouts.
- Related topics.

## Collaborate Proposal Page

Purpose:

Let SMEs, analysts, and partners propose new economic topics that Exalytics can package into dashboards.

Current high-fidelity frame:

- Figma node: `58:2`
- Design name: `Collaborate / Propose Topic Desktop High Fidelity`

Core sections:

- Public header.
- Hero explaining the topic proposal flow.
- Proposal status preview.
- Topic proposal form.
- Collaboration workflow panel.
- Source-document provision area.
- Footer.

Core fields:

- Topic title.
- Country or region.
- Primary data source.
- Update frequency.
- Analytical question.
- Known dimensions.
- Data-packaging notes.

Behavior:

- Submitted proposals should become admin-reviewable records.
- Proposals can later become topics, indicators, dimensions, data sources, dashboard widgets, methodology notes, and AI retrieval context.

## Methodology Page

Purpose:

Explain data definitions, update timing, units, revisions, and sources.

Core sections:

- General methodology.
- Topic-specific methodology links.
- Revision policy.
- Frequency and unit notes.
- Source attribution.

## Admin Dashboard

Purpose:

Give the site owner quick control over content and data health.

Core sections:

- Latest refresh runs.
- Draft notes.
- Recently updated topics.
- Data warnings.
- Quick actions.

## Admin CMS Review

Purpose:

Review AI-generated analyst-note drafts before publishing them to public topic pages.

Current high-fidelity frame:

- Figma node: `58:87`
- Design name: `Admin / CMS Review Desktop High Fidelity`

Core sections:

- Admin sidebar.
- AI draft queue.
- Selected note editor.
- RAG context summary.
- Citations.
- Audit metadata.
- Review actions.

Review actions:

- Publish.
- Request changes.
- Regenerate.
- Save draft.

Behavior:

- AI-generated notes should never publish automatically.
- Review screen must show the refresh run, data snapshot, retrieved context, citations, prompt/model metadata, and review status.

## Admin Notes Editor

Purpose:

Write and publish CMS-style notes.

Core fields:

- Title.
- Slug.
- Topic.
- Summary.
- Body.
- Status: draft or published.
- Published date.
- Source links.

Editor actions:

- Save draft.
- Preview.
- Publish.
- Unpublish.

## Admin Data Imports

Purpose:

Upload, validate, and refresh topic data.

Core sections:

- Import source.
- File upload or refresh trigger.
- Validation result.
- Rows read.
- Rows written.
- Warnings.
- Errors.
- Refresh history.

## Login Page

Purpose:

Let users and admins access Exalytics accounts.

Current high-fidelity frame:

- Figma node: `58:159`
- Design name: `Auth / Login Desktop High Fidelity`

Core sections:

- Public header.
- Login form.
- Microsoft sign-in action.
- Email/password fallback.
- Workspace preview card.
- Footer.

## Sign-Up Page

Purpose:

Let a new user create a free Exalytics account.

Current high-fidelity frame:

- Figma node: `58:197`
- Design name: `Auth / Sign Up Desktop High Fidelity`

Core sections:

- Public header.
- Free account form.
- Free-plan benefit summary.
- Premium upgrade hint.
- Footer.

## Subscription Page

Purpose:

Let users choose, upgrade, and manage Exalytics subscription access.

Current high-fidelity frame:

- Figma node: `58:251`
- Design name: `Subscription / Plans and Billing Desktop High Fidelity`

Core sections:

- Public header.
- Free and Premium plan cards.
- Monthly/annual billing toggle.
- Checkout summary.
- Subscription management states.
- Footer.

Plan behavior:

- Free plan includes public/free topics and limited history.
- Premium plan includes all topics, full history, advanced charts, AI analyst notes, exports, API access, and priority support.
- Billing implementation can be deferred, but the UI should preserve the plan and account states.

## Homepage Collaborate Section

Purpose:

Explain how subject matter experts can collaborate with Exalytics.

Narrative:

1. SME shares an economic topic, question, or data source.
2. Exalytics shapes indicators, units, frequency, sources, and update rules.
3. Exalytics packages the dataset, dashboard charts, notes, and methodology.
4. The topic is published and maintained through the Azure-backed data pipeline.

The section should make collaboration feel concrete: experts bring domain/data ideas, Exalytics turns them into published dashboards and analysis pages.

## Homepage How It Works Section

Purpose:

Explain how Exalytics turns trusted data sources into usable dashboards. This section also covers ingestion and modeling; do not duplicate it as a separate nearby section.

Include:

- Source/provider badges.
- Four-step flow: collect, ingest, model, explore.
- Short subtitle explaining that raw data becomes actionable dashboards.

Use provider badge examples:

- World Bank.
- IMF.
- OECD.
- RBI.
- FRED.
- BEA.
- Eurostat.
- UN Data.

Design note:

Use image upload placeholders for provider logos until official logo files are supplied. Do not use fake initials as final logos.

Cards:

- Ingest: CSV, Excel, APIs, official releases, SME files.
- Validate: periods, units, missing values, revisions, source metadata.
- Model: topics, indicators, observations, dimensions, widgets.
- Publish: charts, analysis, methodology, latest database update time.

## Homepage Pricing Section

Purpose:

Show simple commercial direction without overcomplicating the MVP.

Plans:

- Free.
- Premium.

## Homepage Footer

Purpose:

Give the site a complete product feel and clear navigation.

Include:

- Brand.
- Short description.
- Topics links.
- Product links.
- Company links.
- Copyright.
