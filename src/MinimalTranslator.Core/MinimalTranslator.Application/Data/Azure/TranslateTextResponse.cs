namespace MinimalTranslator.Application.Data.Azure;

// https://learn.microsoft.com/en-us/azure/ai-services/translator/reference/v3-0-translate#response-body
public record TranslatedTextResponse
{
    public DetectedLanguage? DetectedLanguage { get; set; }
    public IReadOnlyList<TranslationItem>? Translations { get; set; }
}

public record TranslationItem
{
    public string? Text { get; set; }
    public string? To { get; set; }
}
