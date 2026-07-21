# Technology Stack

## Recommended Stack

| Layer | Choice | Reason |
|---|---|---|
| Frontend | Blazor Web App | Microsoft-native, C#-first, good fit with ASP.NET Core |
| Backend | ASP.NET Core .NET 10 API or Minimal APIs | Microsoft-native, mature, Azure-friendly |
| Database | Azure SQL Database | Strong structured relational model for topics, indicators, and observations |
| Data Access | Entity Framework Core | Productive and familiar in .NET ecosystem |
| Hosting | Azure App Service | Beginner-friendly, production-capable Azure hosting |
| Authentication | Microsoft Entra ID | Native Microsoft identity for admin and secure areas |
| Data Jobs | Azure Functions | Scheduled imports, validation, and refresh tasks |
| Realtime Push | Azure SignalR Service | Optional later for live dashboard updates |
| File Storage | Azure Blob Storage | Images, source files, exports, attachments |
| Monitoring | Application Insights and Azure Monitor | Errors, performance, telemetry, API health |
| CI/CD | Azure DevOps Pipelines | Microsoft-native deployment pipeline |
| Design | Figma | Wireframes, components, prototypes, design handoff |
| IDE | JetBrains Rider | Primary IDE for this project; do not assume Visual Studio workflows. |

## Why Not Start With Power BI Embedded

Power BI Embedded is powerful, but it can add cost and product complexity too early. Start with Blazor-native dashboard pages and chart components. Add Power BI Embedded later if users need enterprise BI features, embedded reports, row-level security at BI scale, or self-service exploration.

## Why Not Start With Microsoft Fabric

Microsoft Fabric is useful when the platform has many large data pipelines, warehouses, notebooks, and lakehouse needs. For version 1, Azure SQL plus Azure Functions is simpler. Fabric can be introduced later for advanced data engineering.

## Charting Options For Blazor

Prefer chart libraries that work well with Blazor and can support:

- Time-series line charts.
- Bar and column charts.
- Area charts.
- Dual-axis charts when needed.
- Date range filtering.
- Legend toggles.
- Tooltips.
- Export to image or CSV where useful.

Possible options:

- Syncfusion Blazor Charts, if a commercial component suite is acceptable.
- Telerik UI for Blazor, if a commercial suite is acceptable.
- ApexCharts for Blazor, if a lighter charting wrapper is preferred.
- JavaScript chart interop with Apache ECharts or Plotly if advanced analytics interactivity is needed.

Choose the chart library during the design/frontend phase after checking budget, licensing, and interaction needs.

## IDE Rule

Use JetBrains Rider as the development IDE. Avoid Visual Studio-specific setup, screenshots, menus, or assumptions unless the user explicitly asks. The `.sln` file may contain standard Visual Studio format text because that is how .NET solution files are represented; Rider can open and manage the solution.

## Development Workflow

1. Design key screens in Figma.
2. Create a Blazor solution in Rider.
3. Build static UI components first with mock data.
4. Add ASP.NET Core APIs.
5. Add Azure SQL schema and EF Core migrations.
6. Connect UI to API.
7. Add admin/CMS.
8. Add Azure deployment pipeline.

