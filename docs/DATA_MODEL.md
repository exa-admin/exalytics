# Flexible Data Model

## Design Goal

Support many economic topics without creating a new application structure for every dashboard.

The database should represent:

- Topics.
- Indicators.
- Observations.
- Dimensions.
- Dashboard widgets.
- CMS notes.
- AI analyst notes and retrieval context.
- Topic RAG questions, answers, vector chunks, and citations.
- Signed-in user monthly read tracking.
- Data sources.
- Data refresh runs.

## Core Tables

### Topics

Represents a public dashboard or analysis topic.

Example rows:

- Balance of Payments of India.
- Trade Deficit of USA.
- India Forex Reserves.

Suggested fields:

- Id.
- Slug.
- Title.
- Summary.
- CountryOrRegion.
- Category.
- Status.
- CreatedAt.
- UpdatedAt.

### Indicators

Represents a measurable series inside a topic.

Example rows:

- Current account balance.
- Goods exports.
- Goods imports.
- Services exports.
- Services imports.
- Trade deficit.

Suggested fields:

- Id.
- TopicId.
- Code.
- Name.
- Description.
- Unit.
- Frequency.
- DefaultChartType.
- SortOrder.

### Observations

Represents time-series values for indicators.

Suggested fields:

- Id.
- IndicatorId.
- PeriodStart.
- PeriodEnd.
- PeriodLabel.
- Value.
- Unit.
- Frequency.
- IsRevised.
- SourceId.
- IngestedAt.

### Dimensions

Use dimensions when one indicator needs breakdowns by category, country, sector, or flow type.

Example dimensions:

- FlowType: exports, imports, balance.
- Component: goods, services, income, transfers.
- Country: India, USA.
- Currency: USD, INR.

Suggested fields:

- Id.
- Name.
- Code.
- Description.
- SortOrder.

### DimensionValues

Represents allowed values inside a dimension.

Suggested fields:

- Id.
- DimensionId.
- Code.
- Label.
- SortOrder.

### ObservationDimensions

Join table that tags each observation with one or more dimension values.

Suggested fields:

- ObservationId.
- DimensionValueId.

### DashboardWidgets

Stores how each topic page should display charts and metrics.

Suggested fields:

- Id.
- TopicId.
- WidgetType.
- Title.
- IndicatorCodes.
- ChartConfigJson.
- FilterConfigJson.
- SortOrder.
- IsVisible.

### TopicFilterDefinitions

Stores reusable topic-specific filter controls so each topic can have different dimensions without new code.

Example controls:

- Date range slider.
- Goods/services component pills.
- Flow selector: balance, exports, imports.
- Unit selector: USD, INR, percent of GDP.
- Country, partner, sector, or frequency selectors for future topics.

Suggested fields:

- Id.
- TopicId.
- FilterKey.
- Label.
- ControlType.
- DimensionCode.
- DefaultValueJson.
- OptionsJson.
- SortOrder.
- IsVisible.

### TopicNotes

CMS-style notes attached to a topic.

Suggested fields:

- Id.
- TopicId.
- Title.
- Slug.
- BodyMarkdown.
- Status.
- AuthorId.
- PublishedAt.
- UpdatedAt.
- NoteType: manual, AI generated, AI reviewed.
- RefreshRunId.
- DataSnapshotId.
- ReviewStatus.
- PromptVersion.
- ModelName.
- RagContextVersion.

### DataSources

Tracks where data originally came from.

Suggested fields:

- Id.
- Name.
- Url.
- Publisher.
- LicenseNotes.
- RetrievalMethod.

### DataRefreshRuns

Tracks imports and refresh jobs.

Suggested fields:

- Id.
- SourceId.
- TopicId.
- StartedAt.
- CompletedAt.
- Status.
- RowsRead.
- RowsWritten.
- WarningCount.
- ErrorMessage.

### TopicDataSnapshots

Captures the exact data context used for analysis at a point in time.

Use this when AI generates a note so the published narrative can be traced back to the same indicators, observations, units, and refresh run that the model saw.

Suggested fields:

- Id.
- TopicId.
- RefreshRunId.
- SnapshotJson.
- PeriodStart.
- PeriodEnd.
- CreatedAt.
- CreatedBy.

### AnalysisRuns

Tracks each AI analysis generation attempt.

Suggested fields:

- Id.
- TopicId.
- RefreshRunId.
- DataSnapshotId.
- Status.
- PromptVersion.
- ModelName.
- StartedAt.
- CompletedAt.
- TokenUsageJson.
- ErrorMessage.

### RagDocuments

Represents source material available to the analyst agent.

Examples:

- Observation summaries.
- Source and methodology notes.
- Refresh logs.
- Validation warnings.
- Prior analyst notes.
- CMS-authored context.

Suggested fields:

- Id.
- TopicId.
- SourceType.
- SourceEntityId.
- Title.
- ContentText.
- MetadataJson.
- UpdatedAt.

### RagChunks

Stores smaller retrieval chunks for analyst generation.

Suggested fields:

- Id.
- RagDocumentId.
- ChunkText.
- ChunkOrder.
- MetadataJson.
- EmbeddingVectorId or SearchIndexKey.

### TopicVectorChunks

Stores topic-specific retrieval chunks for user-facing RAG answers.

This can initially overlap with `RagChunks`, but keep the concept explicit because public topic Q&A has different access, latency, citation, and safety requirements than background AI note generation.

Suggested fields:

- Id.
- TopicId.
- SourceType: observation, source metadata, methodology, refresh run, validation warning, prior note.
- SourceEntityId.
- PeriodStart.
- PeriodEnd.
- ChunkText.
- EmbeddingVector.
- MetadataJson.
- IsApprovedForPublicAnswers.
- UpdatedAt.

### RagQuestionRuns

Tracks each user-facing topic RAG question and generated answer.

Suggested fields:

- Id.
- UserId.
- TopicId.
- QuestionText.
- NormalizedQuestionText.
- AnswerMarkdown.
- Status.
- ModelName.
- PromptVersion.
- RetrievalConfigJson.
- MatchedChunkIdsJson.
- TokenUsageJson.
- CreatedAt.
- CompletedAt.
- ErrorMessage.

### AnalysisCitations

Links an AI-generated or reviewed note back to the context it used.

Suggested fields:

- Id.
- TopicNoteId.
- RagDocumentId.
- RagChunkId.
- CitationLabel.
- SortOrder.

### RagAnswerCitations

Links a user-facing RAG answer back to its retrieved context.

Suggested fields:

- Id.
- RagQuestionRunId.
- TopicVectorChunkId.
- CitationLabel.
- ExcerptPreview.
- SortOrder.

### UserPlans

Represents the user's current access tier.

Suggested fields:

- Id.
- UserId.
- PlanCode: guest, free, premium, admin.
- Status.
- StartedAt.
- ExpiresAt.
- MonthlyReadLimit.

### UserContentReads

Tracks signed-in reads for topic and series detail pages.

Use this table to enforce the free plan rule: 5 topic/series detail reads per calendar month.

Suggested fields:

- Id.
- UserId.
- ContentKind: topic or series.
- ContentSlug.
- TopicId.
- IndicatorId.
- ReadMonth.
- FirstReadAt.
- LastReadAt.
- CountedAsFreeRead.
- Source: page-view, RAG-question, admin-grant.

## AI Analysis Flow

When a topic refresh completes:

1. Store new observations in Azure SQL.
2. Record the `DataRefreshRuns` row.
3. Create or update topic widgets and latest metrics.
4. Create a `TopicDataSnapshots` row for the analysis period.
5. Update retrieval documents and chunks for observations, source metadata, methodology, refresh logs, and prior notes.
6. Start an `AnalysisRuns` row.
7. Generate a draft `TopicNotes` row with `NoteType = AI generated` and `ReviewStatus = pending`.
8. Let a human review, edit, and publish the note.

The public topic page should show the latest published analyst note while the admin area can show draft AI notes waiting for review.

## Topic RAG Question Flow

When a signed-in user asks a question on a topic detail page:

1. Authenticate the user with Microsoft Entra ID.
2. Check the user's plan and monthly topic/series read count.
3. If access is allowed, record or update a `UserContentReads` row for the topic.
4. Retrieve matching `TopicVectorChunks` from Azure SQL vector search and related structured observations.
5. Generate an answer using only approved retrieval context.
6. Store the request and answer in `RagQuestionRuns`.
7. Store citations in `RagAnswerCitations`.
8. Return answer markdown, citations, and confidence/context metadata to the Razor page.

Guest users should see a preview and sign-in prompt, not the full RAG interaction.

## Monthly Read Access Flow

For topic detail and series detail pages:

1. Guest users can view the preview portion only.
2. Signed-in free users can view 5 topic/series detail pages per month.
3. Reading the same content again in the same month should not double-count unless the product later chooses stricter usage rules.
4. Premium/admin users can bypass the free monthly limit.
5. Listing pages should remain public and should not create `UserContentReads` rows.

## Topic Configuration Pattern

To add a future topic such as Trade Deficit of USA:

1. Add a row in Topics.
2. Add indicator rows.
3. Add dimensions and filter definitions.
4. Load observations.
5. Configure dashboard widgets.
6. Add CMS notes and methodology.
7. Configure retrieval documents for AI analysis.
8. Publish the topic.

Only add custom code when the topic has special calculations or unusual visualizations.
