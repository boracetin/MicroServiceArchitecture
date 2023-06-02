using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace LocalizationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizationController : ControllerBase
    {

        private readonly IStringLocalizer<LocalizationController> _localizer;

        public LocalizationController(IStringLocalizer<LocalizationController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet("GetLocalization")]
        public string  GetLocalization(string stringName, string culture)
        {

            var specifiedCulture = new CultureInfo(culture);
            CultureInfo.CurrentCulture = specifiedCulture;
            CultureInfo.CurrentUICulture = specifiedCulture;
            var options = Options.Create(new LocalizationOptions { ResourcesPath = "Resources" });
            var factory = new ResourceManagerStringLocalizerFactory(options, new LoggerFactory());
            var localizer = new StringLocalizer<LocalizationController>(factory);

            return localizer[stringName];
        }

        [HttpGet("GetAllLocalization")]
        public IEnumerable<LocalizedString> GetAllLocalizations(string culture)
        {

            var specifiedCulture = new CultureInfo(culture);
            CultureInfo.CurrentCulture = specifiedCulture;
            CultureInfo.CurrentUICulture = specifiedCulture;
            var options = Options.Create(new LocalizationOptions { ResourcesPath = "Resources" });
            var factory = new ResourceManagerStringLocalizerFactory(options, new LoggerFactory());
            var localizer = new StringLocalizer<LocalizationController>(factory);

            var allcultures = localizer.GetAllStrings(false);
            return allcultures;

        }
    }
}
