using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Kvickly_Connect.Interfaces;


namespace Kvickly_Connect
{
    public class CreateItemModel : PageModel
        {
            private IItemRepository repo;

            public CreateItemModel(IItemRepository repository)
            {
                repo = repository;
            }

            [BindProperty]
            public Item Item { get; set; }

            public List<Item> Items { get; set; }

            

            public void OnGet()
            {
                //Items = repo.GetAllItems();
            }

            //public IActionResult OnPost()
            //{
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            //repo.AddItem(Item);
            //Items = repo.GetAllItems();
            //return RedirectToPage("CreateItem");
            //}
        }     
    }
