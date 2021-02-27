using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basket.API.Data.Interfaces;
using Basket.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Basket.API.Pages
{
    public class BasketUpdateModel : PageModel
    {
        private readonly IBasketContext _context;
        public BasketUpdateModel(IBasketContext context)
        {
            _context = context;
        }
        public async Task OnGet(BasketCart basketCart){
            basketCart.Username = "Toks";
            var updatedBasketCart = await _context.Redis.StringSetAsync(basketCart.Username, JsonConvert.SerializeObject(basketCart));
        }
    }
}
