using Microsoft.AspNetCore.Mvc;
using SentiScanSocialApi.Interfaces;
using SentiScanSocialApi.Models;

namespace SentiScanSocialApi.Controllers
{
    [ApiController]
    [Route("senti-scan")]
    public class SentiScanController : ControllerBase
    {

        private readonly ILogger<SentiScanController> _logger;
        private readonly ISentiScanRepository _sentiScanRepository;
        private readonly ISentiScanService _sentiScanService;

        public SentiScanController(
            ILogger<SentiScanController> logger, 
            ISentiScanRepository sentiScanRepository, 
            ISentiScanService sentiScanService
        )
        {
            _logger = logger;
            _sentiScanService = sentiScanService;
            _sentiScanRepository = sentiScanRepository;
        }

        [HttpGet("list-messages")]
        public IList<SentiScanMessage> GetLstMessages()
        {
            var messages = _sentiScanRepository.GetAllSentiScanMessages();
            return messages;
        }

        [HttpPost("calculate-sentiment")]
        public IActionResult CalculateSentiment(SentiScanMessage sentiScanMessage)
        {
            var sentimentResult = _sentiScanService.CalculateSentiment(sentiScanMessage);
            return Ok(sentimentResult);
        }

        [HttpPost("update-message")]
        public IActionResult UpdateMessage(SentiScanMessage sentiScanMessage)
        {
            return Ok(200);
        }
    }
}