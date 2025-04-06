using Microsoft.AspNetCore.Mvc;
using satinalma.Data;

namespace satinalma.Component
{
    public class TrendingList:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public TrendingList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var urun = _context.Products.ToList();
            return View(urun);
        }
    }
}
