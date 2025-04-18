using Microsoft.AspNetCore.Mvc;

namespace ContactManager.ViewComponents;

public class HeaderViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}