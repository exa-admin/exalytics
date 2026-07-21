# Figma Workflow And Project Integration

## Goal

Use Figma to design the product clearly before building the Blazor frontend. The Figma file should become the visual source of truth, while this repository remains the implementation and planning source of truth.

## Step 1: Create The Figma File

Create a new Figma design file named:

`Exalytics - Phase 1 Design`

Create these pages in the Figma file:

- `Cover`
- `Sitemap`
- `Wireframes`
- `Design System`
- `High Fidelity`
- `Prototype`
- `Developer Handoff`
- `Archive`

Add a short cover note:

`Microsoft-native economic analytics platform with topic dashboards, CMS notes, and Azure SQL-backed data.`

## Step 2: Set Up Frames

Create these base frames:

- Desktop: `1440 x 1200`
- Laptop: `1280 x 900`
- Tablet: `768 x 1024`
- Mobile: `390 x 844`

Use desktop and mobile first. Tablet can be refined later.

## Step 3: Add The Sitemap

On the `Sitemap` page, create boxes for:

- Homepage: `/`
- Topics: `/topics`
- Topic dashboard: `/topics/{topic-slug}`
- Analysis: `/analysis`
- Analysis note: `/analysis/{note-slug}`
- Collaborate: `/collaborate`

Admin/back-office pages still exist for CMS and data management, but do not include them in the public top navigation.

Use `docs/phase-1-design/SITEMAP_AND_FLOWS.md` as the reference.

## Step 4: Create Low-Fidelity Wireframes

On the `Wireframes` page, design in grayscale first.

Create wireframes for:

1. Homepage desktop.
2. Homepage mobile.
3. Topics listing desktop.
4. Topics listing mobile.
5. Balance of Payments India dashboard desktop.
6. Balance of Payments India dashboard mobile.
7. Analysis note page.
8. Admin notes editor.

Use `docs/phase-1-design/WIREFRAME_NOTES.md` and `docs/phase-1-design/SCREEN_SPECS.md`.

Do not spend time on final colors yet. Focus on layout, hierarchy, and what information appears on each screen.

## Step 5: Create The Design System

On the `Design System` page, create styles or variables for:

- Text colors.
- Background colors.
- Border colors.
- Accent colors.
- Chart colors.
- Font sizes.
- Spacing values.

Use `docs/phase-1-design/DESIGN_SYSTEM.md` as the starting point.

Recommended component groups:

- Navigation.
- Search.
- Topic cards.
- Metric tiles.
- Chart panels.
- Filter bars.
- Buttons.
- Form fields.
- Status badges.
- Note previews.
- Admin sidebar.

## Step 6: Turn Repeated UI Into Components

Create Figma components for anything reused more than once.

Important components:

- `Header / Public`
- `Header / Admin`
- `Card / Topic`
- `Tile / Metric`
- `Panel / Chart`
- `Control / Date Range`
- `Control / Segmented Toggle`
- `Preview / Note`
- `Row / Data Update`
- `Badge / Status`
- `Form / Text Field`
- `Form / Select`
- `Admin / Sidebar`

Use names close to what we will later build in Blazor. Example:

- Figma: `Card / Topic`
- Blazor later: `TopicCard.razor`

## Step 7: Create High-Fidelity Screens

On the `High Fidelity` page, polish these screens:

1. Homepage.
2. Topics listing.
3. Balance of Payments India dashboard.
4. Analysis note page.
5. Admin notes editor.

Use realistic placeholder data, for example:

- Current account balance.
- Goods exports.
- Goods imports.
- Services exports.
- Services imports.
- Current account as percent of GDP.
- Latest period.
- Last updated timestamp.

Keep source, unit, frequency, and last database update visible on dashboard screens.

## Step 8: Create Prototype Links

On the `Prototype` page, connect:

- Homepage search to Topics.
- Featured Balance of Payments India card to dashboard.
- Dashboard note preview to analysis note.
- Admin dashboard to notes editor.
- Notes editor preview to preview state.

The prototype does not need real data. It only needs to prove the navigation and interaction model.

## Step 9: Prepare Developer Handoff

On the `Developer Handoff` page, place final approved frames and annotate:

- Spacing.
- Component names.
- Data fields needed.
- Empty states.
- Loading states.
- Error states.
- Mobile behavior.

Mark approved sections as ready for development in Figma when they are final.

## Step 10: Integrate Figma With This Project

After the Figma file exists, update this repository with:

- Figma file link in `docs/phase-1-design/FIGMA_LINK.md`.
- Final screen list in `docs/phase-1-design/SCREEN_SPECS.md`.
- Final component list in `docs/phase-1-design/DESIGN_SYSTEM.md`.
- Any design decisions in `docs/phase-1-design/PHASE_1_OVERVIEW.md`.

Create this file:

```text
docs/phase-1-design/FIGMA_LINK.md
```

Add:

```markdown
# Figma Link

Phase 1 Figma file:

<paste Figma URL here>
```

## Step 11: Translate Design To Blazor Later

During Phase 2, map Figma components to Blazor components:

| Figma Component | Blazor Component |
|---|---|
| `Header / Public` | `PublicHeader.razor` |
| `Card / Topic` | `TopicCard.razor` |
| `Tile / Metric` | `MetricTile.razor` |
| `Panel / Chart` | `ChartPanel.razor` |
| `Control / Date Range` | `DateRangeFilter.razor` |
| `Preview / Note` | `NotePreview.razor` |
| `Admin / Sidebar` | `AdminSidebar.razor` |

Design tokens from Figma should become CSS variables later, such as:

```css
--color-background: #F7F8FA;
--color-surface: #FFFFFF;
--color-text: #101820;
--color-primary: #0F766E;
--space-1: 4px;
--space-2: 8px;
--space-3: 12px;
--space-4: 16px;
```

## Important Rule

Do not rely on Figma to generate the Blazor application. Use Figma to make design decisions, inspect spacing/colors/assets, and guide implementation. The actual production UI should be built manually in Blazor so it is clean, responsive, and connected to the backend correctly.
