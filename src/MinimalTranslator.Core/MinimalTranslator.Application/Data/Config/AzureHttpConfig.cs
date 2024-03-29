namespace MinimalTranslator.Application.Config;

public record AzureHttpConfig 
{
    public string? Uri { get; set; }
    public string? Region { get; set; }
    public string? Key { get; set; }
    public float LanguageRecognitionScoreThreshold { get; set; }
};
