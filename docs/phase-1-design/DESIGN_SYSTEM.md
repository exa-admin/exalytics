# Design System Direction

## Visual Personality

The interface should feel:

- Analytical.
- Calm.
- Credible.
- Dense but readable.
- More like a professional data portal than a marketing website.
- Lively enough to feel like a modern analytics product, with confident color accents and chart-led visuals.

## Current Homepage Direction

The approved direction is closer to a polished SaaS analytics homepage:

- White header with Exalytics logo.
- Public navigation: Home, Topics, Analysis, Collaborate.
- Large hero headline.
- Bright blue primary actions.
- Large dashboard preview card.
- Multi-color chart lines and badges.
- Clear stats such as topics, data points, and live updates.
- Color accents should support analytics meaning, not pure decoration.

## Typography

Preferred web font stack:

```css
font-family: "Aptos", "Segoe UI", system-ui, sans-serif;
```

Use:

- Large but restrained page titles.
- Compact section headings.
- Tabular numbers for metric tiles.
- Clear labels for units, frequency, and dates.

## Color Direction

Use a neutral base with multiple purposeful accents.

Suggested palette:

| Role | Color |
|---|---|
| Background | `#F7F8FA` |
| Surface | `#FFFFFF` |
| Border | `#D8DEE6` |
| Text | `#101820` |
| Muted text | `#586575` |
| Primary | `#0F766E` |
| Link | `#2563EB` |
| Positive | `#15803D` |
| Warning | `#B7791F` |
| Negative | `#C2410C` |
| Neutral data | `#475569` |

Chart colors should use distinct hues rather than many shades of one color.

## Layout

Use:

- 8px spacing base.
- 1200px to 1320px max content width.
- Compact panels for repeated dashboard elements.
- Responsive grids.
- Sticky or persistent filters only if they do not crowd mobile screens.

## Components

Design reusable Figma components for:

- Header navigation.
- Search input.
- Topic card.
- Metric tile.
- Chart panel.
- Filter bar.
- Segmented toggle.
- Date range selector.
- Note preview.
- Data update row.
- Source/methodology block.
- Admin sidebar.
- Form field.
- Status badge.
- Primary, secondary, and icon buttons.

## States

Design states for:

- Loading data.
- Empty topic results.
- Chart with no data.
- API or refresh error.
- Draft note.
- Published note.
- Data warning.
- Successful refresh.

## Chart Design Rules

- Always show unit and frequency.
- Always show latest period or selected date range.
- Keep legends visible and interactive.
- Use tooltips with date, value, unit, and indicator name.
- Avoid dual-axis charts unless the units genuinely require it.
