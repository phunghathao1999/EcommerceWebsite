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

namespace RazorPages.Pages.Admin
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        public LoginModel()
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public loginModels login { get; set; }
        public accountModels accountModels { get; set; }
        // public async Task<IActionResult> OnPost()
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

        //     return RedirectToPage("Index");
        // }

    }
}