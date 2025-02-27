using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopApp.Infrastructure.Extensions;

namespace ShopApp.Pages
{
    public class DemoModel : PageModel
    {
        public String? FullName => HttpContext?.Session?.GetString("name") ?? "My Friend";

        public DemoModel() 
        {
            
        }
        public void OnGet()
        {
        }

        public void OnPost([FromForm]string name) 
        {
            //FullName = name;
            HttpContext.Session.SetString("name", name);
        }
    }
}
