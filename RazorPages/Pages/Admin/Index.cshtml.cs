using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Admin
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILaptopService _laptopservice;
        public IndexModel(ILaptopService laptopService)
        {
            _laptopservice = laptopService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

    }
}