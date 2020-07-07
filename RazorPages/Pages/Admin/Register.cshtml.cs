using ApplicationCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Admin
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        public registerModels registerModels {get;set;}
    }
}