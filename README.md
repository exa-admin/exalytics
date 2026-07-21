# Exalytics

This workspace contains the planning memory and application source for Exalytics, a Microsoft-native economic analytics web application. The product combines topic dashboards, Azure SQL-backed data, and CMS-style notes.

## Start Here

Read these files first in a new session:

1. `AGENTS.md`
2. `docs/PROJECT_CONTEXT.md`
3. `docs/PHASED_ROADMAP.md`
4. `docs/DESIGN_PLAN.md`
5. `docs/phase-1-design/README.md`

## Core Direction

- Build with Blazor, ASP.NET Core, Azure SQL Database, Azure App Service, Azure Functions, and Microsoft Entra ID.
- Use JetBrains Rider for development. Do not assume Visual Studio as the IDE or workflow.
- Use Figma for design before coding.
- Treat "real time" as reading the latest data from Azure SQL Database.
- Build a flexible topic platform, not a single hardcoded dashboard.

## Active Phase Plan

1. Website and product design in Figma. In progress.
2. Frontend in Blazor with mock data.
3. Azure SQL database and EF Core model.
4. ASP.NET Core API code.
5. Connect frontend to API.
6. CMS and admin area.
7. Azure Functions data refresh jobs.
8. Azure hosting and deployment.
9. Complete Balance of Payments India.
10. Add Trade Deficit USA to prove flexibility.

## First Topic

Balance of Payments of India.

## Future Topic Example

Trade Deficit of USA.

## Workspace Skill

The project skill lives at:

`skills/dataanalytics-platform/SKILL.md`

## Current Work

Phase 1 design has started. Continue from:

`docs/phase-1-design/README.md`

## Local App

The first Blazor web project is at:

`src/Exalytics.Web`

The current Figma node implementation is the homepage rectangle from node `2:5`.
