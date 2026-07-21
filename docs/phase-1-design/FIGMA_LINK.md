# Figma Link

Phase 1 Figma file:

https://www.figma.com/design/GwuSsd20a8zkyZ9mswenH8/Design?node-id=2-5&m=dev

## Implemented Node

- Node: `2:5`
- Size: `1440 x 139`
- Fill: `#d8e3ee`
- Local implementation: `src/Exalytics.Web/Components/Pages/Home.razor`

## Created Wireframes

- `Homepage / Desktop Wireframe`: node `7:2`
- Public header menu: `Home`, `Topics`, `Analysis`, `Collaborate`

## Created High-Fidelity Designs

- `Homepage / Desktop High Fidelity`: node `12:2`
- Header logo node: `12:6`
- Logo source used for header: `exalytics log.PNG`
- Visual direction: bright, lively analytics homepage with blue/cyan primary actions, orange import line, red current-account-deficit area, green live-data badge, and colorful topic/analysis/collaborate teaser cards.
- Homepage has been extended with:
  - Featured economic dashboard cards.
  - A collaboration workflow section.
  - SME idea-to-published-dashboard narrative.
  - How It Works section with source/provider badges.
  - Merged How It Works plus ingest/model section.
  - Free and Premium pricing cards.
  - CTA band.
  - Dark footer.
- Provider areas are logo upload placeholders, not fake logos. Replace each placeholder later with official image assets supplied by the project owner.
- `Topics / Desktop High Fidelity`: node `20:74`
- Topics page includes:
  - Search.
  - Topic category pills.
  - Filter sidebar.
  - Topic cards for live, preview, draft, planned, and collaborate statuses.
  - Collaborate banner for SME topic suggestions.
- `Topic Detail / India BOP Desktop High Fidelity`: node `41:2`
- Topic detail page includes:
  - Topic header with latest period, frequency, unit, last Azure SQL database refresh, live-data status, and download action.
  - KPI cards for the selected topic.
  - Configurable topic controls: date range, component, flow, unit, and frequency.
  - Main chart, supporting charts, latest-observations table, and refresh insight panel.
  - AI analysis context card showing that the note uses observations, source metadata, refresh logs, methodology notes, and prior analyst notes.
  - AI analyst-note section designed as the blog-style narrative that extends after every topic refresh.
- `Collaborate / Propose Topic Desktop High Fidelity`: node `58:2`
- Collaborate proposal page includes:
  - Public page for SMEs, analysts, and partners to submit topic ideas.
  - Fields for topic title, country/region, primary data source, update frequency, analytical question, known dimensions, and data-packaging notes.
  - Workflow panel showing idea, modeling, dashboard build, and refresh/publish steps.
- `Admin / CMS Review Desktop High Fidelity`: node `58:87`
- Admin CMS review page includes:
  - AI draft review queue.
  - Generated analyst-note editor.
  - RAG context chips and citations.
  - Publish, request changes, regenerate, and save draft actions.
- `Auth / Login Desktop High Fidelity`: node `58:159`
- Login page includes:
  - Microsoft sign-in path.
  - Email/password fallback layout.
  - Workspace preview card.
- `Auth / Sign Up Desktop High Fidelity`: node `58:197`
- Sign-up page includes:
  - Free account creation form.
  - Free-plan benefit summary.
  - Premium-upgrade hint.
- `Subscription / Plans and Billing Desktop High Fidelity`: node `58:251`
- Subscription page includes:
  - Free and Premium plan cards.
  - Monthly/annual billing toggle.
  - Checkout summary.
  - Subscription management states: active, trial ending, and payment issue.
