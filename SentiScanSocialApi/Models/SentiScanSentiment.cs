namespace SentiScanSocialApi.Models
{
    public class SentiScanSentiment
    {
        public SentimentType? SentimentType { get; set; }
        public string? CalculationFeedback { get; set; }
    }

    public enum SentimentType
    {
        Neutral = 0,
        Good = 1,
        Bad = 2
    }
}
