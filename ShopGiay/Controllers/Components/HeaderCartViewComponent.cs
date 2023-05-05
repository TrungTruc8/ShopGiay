using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopGiay.Extension;
using ShopGiay.ModelViews;
using System.Collections.Generic;

namespace ShopGiay.Controllers.Components
{
    public class HeaderCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            return View(cart);
        }
    }
}
