# Homepage Design

## Homepage Goal

The homepage should answer one question quickly:

"What economic topic do you want to explore, and what changed recently?"

It should feel like an economic analytics portal, not a generic blog landing page.

## First View

Include:

- Product name or logo.
- Top navigation.
- Prominent search box.
- A concise headline focused on economic data and analysis.
- A short supporting line.
- A visible hint of featured topics below the first view.

Avoid:

- Generic marketing hero copy.
- Decorative graphics that do not show data.
- A homepage that only behaves like a blog archive.

## Navigation

Recommended top-level menu:

- Home.
- Topics.
- Series.
- Collaborate.

Admin/back-office pages should not appear in the public top navigation. They can be reached through a secure URL later.

## Homepage Sections

### 1. Search And Discovery

A large search area where users can search:

- Balance of Payments of India.
- Trade Deficit of USA.
- Forex reserves.
- Inflation.
- GDP growth.
- Current account deficit.

### 2. Featured Topics

Cards or compact panels for important dashboards:

- Balance of Payments of India.
- Trade Deficit of USA.
- India Forex Reserves.
- Inflation Trends.
- GDP Growth.

Each topic card should show:

- Topic name.
- Country or region.
- Category.
- Latest available period.
- One key metric.
- Last updated timestamp from Azure SQL.

### 3. Latest Data Updates

Database-driven list of recently refreshed topics or indicators:

- Topic.
- Indicator.
- Latest period.
- Last database update time.
- Source.

### 4. Latest Analysis Notes

CMS-driven list of recent notes:

- Title.
- Topic.
- Published date.
- Short summary.

### 5. Topic Explorer

Filterable area by:

- Country or region.
- Category.
- Frequency.
- Data type.

### 6. Featured Topics

Use colorful cards for several dashboards:

- India Balance of Payments.
- USA Trade Deficit.
- India Forex Reserves.
- Inflation Watch.

Cards should show category, metric, latest period or status, and a small chart signal.

### 7. Collaborate

Explain the collaboration model:

- A subject matter expert suggests a topic, question, or data source.
- Exalytics defines the indicators, units, frequency, sources, and refresh rules.
- Exalytics packages the data into dashboards, charts, notes, and methodology.
- The topic is published and maintained on the website.

### 8. How It Works

Explain the user-facing data flow:

- Exalytics collects from trusted data websites and partners.
- Exalytics ingests the source files, APIs, releases, or SME-provided data.
- Exalytics models the data into topics, indicators, observations, dimensions, and dashboard widgets.
- Users explore the published dashboards, notes, sources, and update status.

Use source/provider badges for well-known data providers such as:

- World Bank.
- IMF.
- OECD.
- RBI.
- FRED.
- BEA.
- Eurostat.
- UN Data.

Use upload placeholders in Phase 1. Replace placeholders with official source logo image assets after the project owner supplies them. Do not use fake logo initials for final design.

### 9. Pricing

Include two pricing cards:

- Free: public topics, basic charts, recent data, published analysis.
- Premium: all topics, deeper history, advanced charts, data export, custom packaging/support.

### 10. Footer

Use a dark footer with:

- Exalytics brand.
- Short product description.
- Topic links.
- Product links.
- Company links.
- Copyright.

## Visual Direction

Use a serious analytics style:

- Clean layout.
- Dense but readable information.
- Charts and numbers visible early.
- Strong typography hierarchy.
- Restrained color palette with purposeful accents.
- Avoid a single-color theme.

## Current Homepage Hero Adjustment

The homepage hero should not feel over-zoomed. Keep the headline, dashboard preview, hero buttons, and stats about 10–20% more compact than the first high-fidelity draft while preserving the same Figma-inspired composition.

Preferred current direction:

- left headline remains dominant but not oversized;
- dashboard preview fits comfortably beside the copy;
- CTA buttons are large enough to scan but not oversized;
- hero stats stay compact under the CTA row;
- topic, series, and collaborate teaser buttons remain visible without forcing excessive vertical height.

## Figma Deliverables

Design these before coding:

1. Desktop homepage.
2. Mobile homepage.
3. Topic listing page.
4. Topic dashboard page.
5. Admin notes editor.
6. Reusable components: topic card, metric tile, chart panel, filter bar, note preview.
