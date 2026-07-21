# Sitemap And User Flows

## Public Sitemap

```text
/ 
  /topics
    /topics/{topic-slug}
  /analysis
    /analysis/{note-slug}
  /collaborate
```

## Admin Sitemap

```text
/admin
  /admin/topics
    /admin/topics/new
    /admin/topics/{topic-id}
  /admin/indicators
    /admin/indicators/new
    /admin/indicators/{indicator-id}
  /admin/notes
    /admin/notes/new
    /admin/notes/{note-id}
  /admin/data-imports
  /admin/refresh-runs
  /admin/settings
```

## Primary Public Flow

1. User lands on homepage.
2. User searches or selects a featured topic.
3. User opens Balance of Payments of India.
4. User reviews metric tiles and main chart.
5. User adjusts date range or toggles goods/services.
6. User reads the analysis note attached to the topic.
7. User checks source and methodology.

## Topic Discovery Flow

1. User opens Topics.
2. User filters by country, category, frequency, or data type.
3. User scans topic cards.
4. User opens a dashboard.

## Analysis Reading Flow

1. User opens Analysis.
2. User selects a note.
3. User reads note content.
4. User follows linked dashboard context.

## Admin Publishing Flow

1. Admin signs in.
2. Admin opens Notes.
3. Admin creates or edits a note.
4. Admin links the note to a topic.
5. Admin saves draft.
6. Admin previews.
7. Admin publishes.

## Admin Data Flow

1. Admin signs in.
2. Admin opens Data Imports.
3. Admin uploads or triggers refresh.
4. System validates rows.
5. Admin reviews warnings.
6. Database stores observations.
7. Public dashboard shows latest database values.
