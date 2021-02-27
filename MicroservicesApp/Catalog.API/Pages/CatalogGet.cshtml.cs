using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Pages
{
    public class CatalogGetModel : PageModel
    {
        private readonly ICatalogContext _context;
        public List<Product> products;
        public CatalogGetModel(ICatalogContext context)
        {
            _context = context;
        }
        public async Task OnGet()
        {
            products = await _context.Products.Find(p => true).ToListAsync();
        }
        public async Task<bool> Delete(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(m => m.Id, id);
            DeleteResult deleteResult = await _context
                                                .Products
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
