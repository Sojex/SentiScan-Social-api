using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Interfaces
{
    public interface ISentiScanRepository
    {
        IList<SentiScanMessage> GetAllSentiScanMessages();
    }
}
