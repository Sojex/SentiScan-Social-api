using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Interfaces
{
    public interface ISentiScanService
    {
        SentiScanSentiment CalculateSentiment(SentiScanMessage sentiScanMessage);
    }
}
