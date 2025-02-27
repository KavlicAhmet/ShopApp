using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
