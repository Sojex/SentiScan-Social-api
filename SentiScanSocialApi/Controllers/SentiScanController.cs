using Microsoft.AspNetCore.Mvc;
using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Controllers
{
    [ApiController]
    [Route("senti-scan")]
    public class SentiScanController : ControllerBase
    {

        private readonly ILogger<SentiScanController> _logger;

        public SentiScanController(ILogger<SentiScanController> logger)
        {
            _logger = logger;
        }

        [HttpGet("list-messages")]
        public IList<SocialMediaMessage> GetLstMessages()
        {
            var lstMessages = new List<SocialMediaMessage>();

            var msg1 = new SocialMediaMessage {
                Id = 1,
                MessageContent = "Hey John, how are you doing?",
                SenderId = 1,
                ReceiverId = 2,
            };

            var msg2 = new SocialMediaMessage
            {
                Id = 2,
                MessageContent = "Hey John, how are you doing?",
                SenderId = 1,
                ReceiverId = 2,
            };

            var msg3 = new SocialMediaMessage
            {
                Id = 3,
                MessageContent = "I'm doing alright. What about you?",
                SenderId = 2,
                ReceiverId = 1,
            };

            var msg4 = new SocialMediaMessage
            {
                Id = 4,
                MessageContent = "Ah same old, been busy with work and family.",
                SenderId = 1,
                ReceiverId = 2,
            };


            lstMessages.Add(msg1);
            lstMessages.Add(msg2);
            lstMessages.Add(msg3);
            lstMessages.Add(msg4);

            return lstMessages;
        }

        [HttpPost("update-message")]
        public IActionResult UpdateMessage(SocialMediaMessage socialMediaMessage)
        {
            return Ok(200);
        }
    }
}