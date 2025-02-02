using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutTeamsPartial:ViewComponent
    {
        private readonly ITeammateService _teammateService;

        public _AboutTeamsPartial(ITeammateService teammateService)
        {
            _teammateService = teammateService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _teammateService.TLoadLast4Records();
            return View(values);
        }
    }
}
