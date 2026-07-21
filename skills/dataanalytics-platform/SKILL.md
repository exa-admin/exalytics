---
name: dataanalytics-platform
description: Plan, design, and build this Microsoft-native economic data analytics web application. Use when working on the portfolio project for topic dashboards, CMS notes, Azure SQL-backed real-time data, Blazor frontend, ASP.NET Core backend, Azure hosting, Figma design planning, JetBrains Rider development, or future flexible topic dashboards such as Balance of Payments of India and Trade Deficit of USA.
---

# Data Analytics Platform Skill

## Core Context

Build a Microsoft-native analytics portal that combines economic dashboards with CMS-style notes. The first topic is Balance of Payments of India. The platform must later support more topics, such as Trade Deficit of USA, using the same core architecture.

Real time means the website reads the latest data from Azure SQL Database. Do not design public pages that call external data providers directly at page load.

Topic detail pages should support AI-generated analyst notes at the end of the charts. The analyst agent uses Azure SQL-backed observations, indicators, dimensions, source metadata, methodology notes, refresh logs, validation warnings, and prior analyst notes as retrieval context. Generated notes are drafts until a human reviews and publishes them.

## Preferred Stack

- Blazor Web App for frontend.
- ASP.NET Core .NET 10 API or Minimal APIs for backend.
- Azure SQL Database for topic, indicator, observation, CMS, and configuration data.
- Entity Framework Core for data access.
- Azure App Service for hosting.
- Microsoft Entra ID for admin authentication.
- Azure Functions for scheduled or manual data refresh jobs.
- Azure Blob Storage for files and assets.
- Azure Monitor and Application Insights for observability.
- Azure DevOps Pipelines for deployment.
- JetBrains Rider for development. Do not assume Visual Studio workflows.
- Figma for design before implementation.

## Workflow

1. Complete website and product design in Figma.
2. Build the Blazor frontend with mock data.
3. Design the Azure SQL database and EF Core model.
4. Write ASP.NET Core API code.
5. Connect the frontend to the API.
6. Add the CMS/admin area with Microsoft Entra ID.
7. Add Azure Functions data refresh jobs.
8. Deploy to Azure.
9. Complete Balance of Payments India as the first real dashboard.
10. Add Trade Deficit USA to prove the platform is flexible.

## Architecture Rules

- Treat each dashboard as a Topic with Indicators, Observations, DashboardWidgets, TopicNotes, DataSources, and DataRefreshRuns.
- Include TopicDataSnapshots, AnalysisRuns, RagDocuments, RagChunks, and AnalysisCitations when designing the AI analysis workflow.
- Keep Balance of Payments India as the first topic, not a hardcoded application assumption.
- Prefer configuration-driven widgets and indicators.
- Add custom code only for genuinely unique calculations or visualizations.
- Always expose source, unit, frequency, latest period, and last database update time.
- Keep the MVP simple before adding Microsoft Fabric, Power BI Embedded, or Azure SignalR.

## Reference Files

Read these project files when needed:

- `AGENTS.md` for project-wide instructions.
- `docs/PROJECT_CONTEXT.md` for product memory.
- `docs/TECH_STACK.md` for stack decisions.
- `docs/DESIGN_PLAN.md` for design-first phases.
- `docs/phase-1-design/README.md` for current Phase 1 design work.
- `docs/PHASED_ROADMAP.md` for implementation sequencing.
- `docs/DATA_MODEL.md` for the flexible topic schema.
- `docs/HOMEPAGE_DESIGN.md` for homepage direction.
- `agents/` for specialized role briefs.
