# Phased Roadmap

## Active Build Order

Use this order for the project:

1. Website and product design.
2. Frontend with mock data.
3. Database design.
4. Backend/API code.
5. Connect frontend to API.
6. CMS/admin area.
7. Data refresh jobs.
8. Azure deployment.
9. First real dashboard.
10. Second topic to prove flexibility.

## Phase 0: Project Memory And Setup

Goal:

Create durable project instructions, planning docs, and reusable skill context.

Outputs:

- `AGENTS.md`.
- Project documentation.
- Workspace-local Codex skill.
- Agent role briefs.

## Phase 1: Website And Product Design

Status:

High-fidelity public, topic, admin review, authentication, and subscription screens are now drafted in Figma. Phase 1 is ready for design review before Phase 2 frontend implementation.

Goal:

Finish the product design before app implementation.

Tools:

- Figma.

Outputs:

- Figma sitemap.
- Figma wireframes.
- Figma design system.
- Figma high-fidelity screens.
- Interactive prototype.
- Final screen inventory.
- Color palette.
- Typography.
- Reusable components.
- Mobile and desktop layouts.

Screens:

- Homepage.
- Topics listing.
- Topic dashboard.
- Analysis note page.
- Methodology page.
- Collaborate proposal page.
- Login page.
- Sign-up page.
- Subscription and billing page.
- Admin topic manager.
- Admin notes editor.
- Admin AI/CMS review queue.
- Admin data upload or refresh page.

Exit condition:

The exact pages, layouts, components, and dashboard behavior are clear enough to build.

## Phase 2: Frontend With Mock Data

Goal:

Build the website UI without database or API dependencies first.

Tools:

- JetBrains Rider. Do not assume Visual Studio workflows.
- Blazor Web App.

Outputs:

- Main layout and navigation.
- Homepage.
- Topics listing page.
- Topic dashboard page.
- Collaborate proposal page.
- Login page.
- Sign-up page.
- Subscription and billing page.
- Admin AI/CMS review shell with mock drafts.
- Chart components with mock data.
- Metric cards.
- Filters and date slider.
- Notes preview components.
- Responsive mobile layout.

Exit condition:

The app feels like the final product using fake Balance of Payments data, even before the backend exists.

## Phase 3: Database Design

Goal:

Design the flexible Azure SQL structure.

Tools:

- Azure SQL Database.
- Entity Framework Core.

Outputs:

- `Topics`.
- `Indicators`.
- `Observations`.
- `Dimensions`.
- `DimensionValues`.
- `TopicFilterDefinitions`.
- `DashboardWidgets`.
- `TopicNotes`.
- `DataSources`.
- `DataRefreshRuns`.
- `TopicDataSnapshots`.
- `AnalysisRuns`.
- `RagDocuments`.
- `RagChunks`.
- `AnalysisCitations`.
- User and role mapping as needed.
- EF Core models.
- EF Core migrations.
- Seed data for Balance of Payments India.

Exit condition:

Azure SQL can store topics, indicators, chart data, dashboard configuration, and notes for multiple topics.

## Phase 4: Backend/API Code

Goal:

Create the ASP.NET Core backend that reads from Azure SQL.

Tools:

- ASP.NET Core .NET.
- Entity Framework Core.

Outputs:

- Get all topics.
- Get one topic by slug.
- Get dashboard data for a topic.
- Get indicators.
- Get observations by date range.
- Get latest updates.
- Get published notes.
- Admin create/edit topic.
- Admin create/edit notes.
- Admin upload/import data.
- Local API testing.

Exit condition:

Frontend can request real topic, chart, and note data from backend APIs.

## Phase 5: Connect Frontend To API

Goal:

Replace mock data with real API data.

Outputs:

- Homepage reads latest topics from API.
- Topic page reads chart data from API.
- Filters call API or filter loaded API data.
- Notes come from CMS tables.
- Last updated timestamp appears on dashboard.

Exit condition:

Balance of Payments India works as a database-backed topic page.

## Phase 6: CMS/Admin Area

Goal:

Enable secure management of notes, topics, indicators, and data.

Tools:

- Blazor admin pages.
- Microsoft Entra ID.

Outputs:

- Microsoft Entra ID authentication.
- Admin authorization policy.
- Notes editor.
- Topic editor.
- Indicator editor.
- Data upload or import screen.
- Draft and publish workflow.

Exit condition:

You can update published analysis notes and basic topic metadata without editing code.

## Phase 7: Data Refresh Jobs

Goal:

Keep Azure SQL updated from controlled backend jobs.

Outputs:

- Azure Function for scheduled refresh.
- Manual admin-triggered refresh.
- Refresh logs.
- Data validation warnings.
- Clear latest database update timestamp.

Exit condition:

Public pages always read the latest available database values, and refresh history is visible.

## Phase 8: Azure Deployment

Goal:

Host the MVP on Azure.

Outputs:

- Azure App Service.
- Azure SQL Database.
- Azure Blob Storage if needed.
- Application Insights.
- Azure DevOps Pipeline.
- Environment configuration.

Exit condition:

The app is live on Azure with production configuration, monitoring, and secure admin access.

## Phase 9: First Production Topic

Goal:

Complete Balance of Payments of India as the first real topic.

Outputs:

- Final dashboard.
- Real loaded data in Azure SQL.
- CMS notes.
- Methodology.
- Source attribution.
- Tested filters and charts.

Exit condition:

Balance of Payments India is polished enough to show users.

## Phase 10: Add Second Topic

Goal:

Prove the platform is flexible.

Recommended second topic:

- Trade Deficit of USA.

Outputs:

- New topic configuration.
- New indicators.
- New observations.
- New dashboard widgets.
- No major app rewrite.

Exit condition:

Trade Deficit USA is added mostly through data and configuration, proving the topic-platform design.
