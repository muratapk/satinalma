using Microsoft.AspNetCore.Mvc;
using satinalma.Data;

namespace satinalma.Component
{
    public class BestSelling:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public BestSelling(ApplicationDbContext context)
        {
            _context= context;
        }
        public IViewComponentResult Invoke()
        {
            var veri = _context.Products.Take(15).OrderByDescending(m=>m.price).ToList();
            return View(veri);
        }

    }
}
