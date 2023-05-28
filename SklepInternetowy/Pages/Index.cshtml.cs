using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SklepInternetowy.Data;
using SklepInternetowy.Models;

namespace SklepInternetowy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<Product> ProductList { get; set; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            ProductList = _db.Products.ToList();
        }
    }
}