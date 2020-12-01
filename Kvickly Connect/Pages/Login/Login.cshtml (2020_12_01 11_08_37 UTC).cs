using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kvickly_Connect.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            ViewData["Confirmation"] = "Confirmed";
            return RedirectToPage("/Index");
        }
    }
}
