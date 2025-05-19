namespace SentiScanSocialApi.Models
{
    public class SentiScanMessage
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string? MessageContent { get; set; }
    }
}
