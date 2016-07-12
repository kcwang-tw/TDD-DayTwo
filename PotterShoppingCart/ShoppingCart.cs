using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        /// <summary>
        /// 購物車結帳。
        /// </summary>
        /// <param name="order">訂單。</param>
        /// <returns></returns>
        public int CheckOut(List<PotterSeries> order)
        {
            int count = order.Sum(x => x.Quantity);
            double discount = 1 - (count - 1) * 0.05;

            return (int)(100 * count * discount);
        }
    }
}
