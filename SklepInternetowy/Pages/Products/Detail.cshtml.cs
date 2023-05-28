using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SklepInternetowy.Data;
using SklepInternetowy.Models;

namespace SklepInternetowy.Pages.Products
{
    public class DetailModel : PageModel
    {
        private readonly AppDbContext _db;
        public Product Product { get; set; }
        public DetailModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Product = _db.Products.Find(id);
            }
        }
    }
}
