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

            return 100 * count;
        }
    }
}
