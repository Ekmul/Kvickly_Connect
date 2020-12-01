using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Kvickly_Connect.Models;
using Kvickly_Connect.Interfaces;
using Kvickly_Connect.Helpers;

namespace Kvickly_Connect.Pages.Login
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Customer customer { get; set; }
        private ICustomerRepository customs;
        public RegisterModel(ICustomerRepository repo) 
        {
            customs = repo;
        }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Confirmation"] = "Confirmed";
            JsonFileWritter.WriteCustomerToJson(customer);
            return RedirectToPage("/Index");
        }
    }
}
