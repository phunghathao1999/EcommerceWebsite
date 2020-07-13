using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presenters.Pages.Admin
{
    [Authorize(Roles = "ADMINISTRATOR")]
    public class RegisterModel : PageModel
    {
        private readonly IUserIdentityService _useridentityservice;
        public RegisterModel(IUserIdentityService userIdentityService)
        {
            _useridentityservice = userIdentityService;
        }

        [BindProperty]
        public registerModels registerModels { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = registerModels.Email, Email = registerModels.Email};
                var result = await _useridentityservice.CreateUserAsync(user,registerModels.Password);
                if(result.Succeeded)
                {
                    await _useridentityservice.AddRoleToUserAsync(user,"Administrator");
                    await _useridentityservice.LoginAsync(registerModels.Email, registerModels.Password, false, false);
                    return RedirectToPage("Index");
                }
                foreach(var error in result.Errors)
                    ModelState.AddModelError("",error.Description);
            }
            return Page();
        }
    }
}