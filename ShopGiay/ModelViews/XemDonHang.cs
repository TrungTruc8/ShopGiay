using ShopGiay.Models;
using System;
using System.Collections.Generic;


namespace ShopGiay.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}