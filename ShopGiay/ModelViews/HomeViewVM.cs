using ShopGiay.Models;
using System.Collections.Generic;

namespace ShopGiay.ModelViews
{
    public class HomeViewVM
    {
        public List<TinDang> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }

        public QuangCao quangcao { get; set; }
    }
}
