using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ICA2.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {

        
        public string pizzaname { get; set; }

        public float PizzaPrice { get; set; }
        

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(pizzaname))
            {
                pizzaname = "";
            }
        }




    }
}
