using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace VovaTranslator.Controllers
{
    public class TranslateController : Controller
    {
        private readonly ILogger<TranslateController> _logger;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public TranslateController(ILogger<TranslateController> logger, IStringLocalizer<SharedResource> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        public IActionResult Translate()
        {
            
            return View();
        }
    }
}
