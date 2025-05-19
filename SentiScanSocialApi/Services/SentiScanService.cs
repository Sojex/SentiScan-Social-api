using SentiScanSocialApi.Interfaces;
using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Services
{
    public class SentiScanService : ISentiScanService
    {
        public SentiScanService() { }

        public SentiScanSentiment CalculateSentiment(SentiScanMessage sentiScanMessage)
        {
            var neturalReturn = new SentiScanSentiment()
            {
                SentimentType = SentimentType.Neutral,
                CalculationFeedback = "Niether good nor bad"
            };

            var noDataReturn = new SentiScanSentiment()
            {
                CalculationFeedback = "No data",
                SentimentType = null
            };

            if (sentiScanMessage == null)
                return noDataReturn;

            var msgContent = sentiScanMessage?.MessageContent?.ToLower();
            if (string.IsNullOrEmpty(msgContent))
                return noDataReturn;

            var positiveWords = new List<string>() { "happy", "good", "great", "awesome" };

            var negativeWords = new List<string>() {
                "bad",
                "no",
                "not good",
                "sad"
            };

            var messageWords = msgContent
                .ToLower()
                .Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var containsGoodWords = positiveWords.Any(word => messageWords.Contains(word.ToLower()));
            var containsBadWords = negativeWords.Any(word => messageWords.Contains(word.ToLower()));

            if (containsGoodWords && !containsBadWords)
            {
                return new SentiScanSentiment()
                {
                    SentimentType = SentimentType.Good,
                    CalculationFeedback = "Contains the following good words: "
                };
            }

            if (containsBadWords && !containsGoodWords)
            {
                return new SentiScanSentiment()
                {
                    SentimentType = SentimentType.Bad,
                    CalculationFeedback = "Contains the following bad words: "
                };
            }


            return neturalReturn;
        }
    }
}
