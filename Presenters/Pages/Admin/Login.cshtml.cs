using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presenters.Pages.Admin
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly IUserIdentityService _useridentityservice;
        public LoginModel(IUserIdentityService userIdentityService)
        {
            _useridentityservice = userIdentityService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public loginModels login { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var result = await _useridentityservice.LoginAsync(login.Email, login.Password, login.RememberMe, false);
                
                if(result.Succeeded)
                    return RedirectToPage("Index");
            }

            return Page();
        }

    }
}