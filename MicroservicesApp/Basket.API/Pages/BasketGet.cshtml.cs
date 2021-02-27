using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basket.API.Data.Interfaces;
using Basket.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Basket.API.Pages
{
    public class BasketModel : PageModel
    {
        private readonly IBasketContext _context;
        public BasketCart Cart;
        public BasketModel(IBasketContext context)
        {
            _context = context;
        }
        public async Task OnGet()
        {
            var basket = await _context.Redis.StringGetAsync("Toks");
            Cart = JsonConvert.DeserializeObject<BasketCart>(basket);
        }
    }
}
