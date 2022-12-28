using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICA2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ICA2.Pages.Form
{

    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public pizzamodel Pizaa { get; set; }
        public float PizzaPrice { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            PizzaPrice = Pizaa.BasePrice;
            if (Pizaa.TomatoSauce) PizzaPrice += 2;
            if (Pizaa.Cheese) PizzaPrice += 2;
            if (Pizaa.Peperoni) PizzaPrice += 2;

            if (Pizaa.Mushroom) PizzaPrice += 2;
            if (Pizaa.Tuna) PizzaPrice += 5;
            if (Pizaa.Pineapple) PizzaPrice += 2;

            if (Pizaa.Ham) PizzaPrice += 2;
            if (Pizaa.Beef) PizzaPrice += 2;


            return RedirectToPage("/CheckOut/ThankYou", new { Pizaa.pizzaname, PizzaPrice });


        }
    }
}
