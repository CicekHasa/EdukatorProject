using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutFeaturePartial:ViewComponent
    {
        private readonly ISiteFeatureService _siteFeatureService;

        public _AboutFeaturePartial(ISiteFeatureService siteFeatureService)
        {
            _siteFeatureService = siteFeatureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _siteFeatureService.TGetLast4Record();
            return View(values);
        }
    }
}
