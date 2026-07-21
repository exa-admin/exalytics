# Project Instructions

Project name: Exalytics.

## Product Vision

Build a Microsoft-native data analytics web application that mixes economic topic dashboards with CMS-style analysis notes. The first topic is Balance of Payments of India. Future topics should include dashboards such as Trade Deficit of USA, India forex reserves, inflation, GDP growth, and other macroeconomic datasets.

The product should feel like an economic analytics portal, not a generic blog. Users should be able to browse topics, read analysis, and interact with charts powered by the latest data stored in Azure SQL Database.

## Key Decisions

- Use a Microsoft-native stack.
- Use JetBrains Rider for development. Do not assume Visual Studio as the IDE or workflow.
- Use Figma for page and component design before implementation.
- Treat "real time" as reading the latest available data from Azure SQL Database, not directly from external sources on page load.
- Build the system as a configurable topic platform, not a one-off hardcoded Balance of Payments page.
- Start with design and information architecture before writing application code.
- Topic detail pages must support AI-generated analyst notes that use Azure SQL-backed topic data, source metadata, refresh logs, methodology notes, and prior notes as retrieval context. Draft AI notes require human review before publishing.

## Preferred Technology Stack

- Frontend: Blazor Web App with reusable Razor components.
- Backend: ASP.NET Core Web API or Minimal APIs on .NET 10 LTS.
- Database: Azure SQL Database.
- ORM/data access: Entity Framework Core, with raw SQL or stored procedures only where performance requires it.
- Hosting: Azure App Service.
- Authentication: Microsoft Entra ID, with admin-only access for CMS and data management.
- Data jobs: Azure Functions for scheduled imports, refreshes, and validation jobs.
- Realtime UI updates: Azure SignalR Service only when live push is truly needed.
- Files/assets: Azure Blob Storage.
- Monitoring: Azure Monitor and Application Insights.
- Deployment: Azure DevOps Pipelines.
- Design: Figma for wireframes, component design, and prototypes.
- IDE: JetBrains Rider. Do not use Visual Studio-specific instructions unless explicitly requested.

## Architecture Principles

- Keep topics flexible. New dashboards should usually be added by creating topic records, indicator records, observations, widget configuration, and CMS content.
- Avoid hardcoding topic-specific logic unless the topic has genuinely unique calculations.
- Keep public dashboard pages read-optimized.
- Keep admin/CMS pages secure and separated from public pages.
- Always show the data source, last database update time, period covered, unit, and frequency.
- Prefer simple architecture first: Blazor, ASP.NET Core, Azure SQL, App Service, and Azure Functions. Add Microsoft Fabric or Power BI Embedded later only if needed.

## First Topic Scope

Balance of Payments of India should eventually show:

- Current account balance.
- Current account deficit or surplus.
- Goods exports.
- Goods imports.
- Services exports.
- Services imports.
- Net goods balance.
- Net services balance.
- Current account as percent of GDP.
- Date range filtering.
- Goods and services toggles.
- Unit switching where useful, such as USD, INR, or percent of GDP.
- Explanatory notes and analysis written through the CMS.
- AI analyst-note drafts that extend over time when new data refreshes are processed.

## Documentation Map

- `docs/PROJECT_CONTEXT.md`: Product context and architectural memory.
- `docs/TECH_STACK.md`: Technology choices and alternatives.
- `docs/DESIGN_PLAN.md`: Design-first phase plan.
- `docs/PHASED_ROADMAP.md`: End-to-end phased delivery roadmap.
- `docs/DATA_MODEL.md`: Flexible topic and indicator data model.
- `docs/HOMEPAGE_DESIGN.md`: Homepage structure and UX direction.
- `agents/`: Role briefs for future Codex sub-agents or planning passes.
- `skills/dataanalytics-platform/`: Workspace-local Codex skill for this project.
