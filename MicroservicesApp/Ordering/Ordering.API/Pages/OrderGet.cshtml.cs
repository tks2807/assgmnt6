using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ordering.Core.Entities;
using Ordering.Infrastructure.Data;

namespace Ordering.API.Pages
{
    public class OrderGetModel : PageModel
    {
        protected readonly OrderContext _dbContext;
        public List<Order> order;
        public OrderGetModel(OrderContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGet(string username)
        {
            order = await _dbContext.Orders
                      .Where(o => o.Username == username)
                      .ToListAsync();
        }
    }
}
