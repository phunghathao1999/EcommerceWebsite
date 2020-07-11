using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Admin
{
    // [Authorize(Roles = "ADMINISTRATOR")]
    public class LogoutModel : PageModel
    {
        private readonly IUserIdentityService _useridentityservice;
        public LogoutModel(IUserIdentityService userIdentityService)
        {
            _useridentityservice = userIdentityService;
        }

        public async Task<IActionResult> OnGet()
        {
            await _useridentityservice.LogoutAsync();
            return RedirectToPage("/Admin/Login");
        }
    }
}