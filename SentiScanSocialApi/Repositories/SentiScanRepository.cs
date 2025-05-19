using SentiScanSocialApi.Interfaces;
using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Repositories
{
    public class SentiScanRepository : ISentiScanRepository
    {

        private readonly ILogger<SentiScanRepository> _logger;

        public SentiScanRepository(
            ILogger<SentiScanRepository> logger
        ) {
            _logger = logger;
        }

        public IList<SentiScanMessage> GetAllSentiScanMessages()
        {
            //TBD actually hook up the db
            var lstMessages = new List<SentiScanMessage>();

            var msg1 = new SentiScanMessage
            {
                Id = 1,
                MessageContent = "Hey John, how are you doing?",
                SenderId = 1,
                ReceiverId = 2,
            };

            var msg2 = new SentiScanMessage
            {
                Id = 2,
                MessageContent = "Hey Bob, I am doing well, and yourself?",
                SenderId = 1,
                ReceiverId = 2,
            };

            var msg3 = new SentiScanMessage
            {
                Id = 3,
                MessageContent = "That is great to hear!",
                SenderId = 2,
                ReceiverId = 1,
            };

            var msg4 = new SentiScanMessage
            {
                Id = 4,
                MessageContent = "Yes, mic drop.",
                SenderId = 1,
                ReceiverId = 2,
            };


            lstMessages.Add(msg1);
            lstMessages.Add(msg2);
            lstMessages.Add(msg3);
            lstMessages.Add(msg4);

            return lstMessages;
        }
    }
}
