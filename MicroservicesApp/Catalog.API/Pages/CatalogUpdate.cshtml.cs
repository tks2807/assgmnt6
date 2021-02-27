using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;

namespace Catalog.API.Pages
{
    public class CatalogUpdateModel : PageModel
    {
        private readonly ICatalogContext _context;
        public CatalogUpdateModel(ICatalogContext context)
        {
            _context = context;
        }
        public async Task OnGet(string id, Product product)
        {
            var updateResult = await _context
                                        .Products
                                        .ReplaceOneAsync(filter: g => g.Id == id, replacement: product);
        }
    }
}
