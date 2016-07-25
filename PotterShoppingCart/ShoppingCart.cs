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
            var price = 0;

            // 取得各買一集的最大本數
            var maxQuantity = order.Max(x => x.Quantity);

            for (int i = 1; i <= maxQuantity; i++)
            {
                int nowQuantity = GetAdditionalVolumesCount(order, i);
                price += (int)(100 * nowQuantity * GetDisCount(nowQuantity));
            }

            return price;
        }

        /// <summary>
        /// 依據本數取得折扣。
        /// </summary>
        /// <param name="count">書本數量。</param>
        /// <returns></returns>
        private double GetDisCount(int count)
        {
            Dictionary<int, double> discount = new Dictionary<int, double>
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 0.95 },
                { 3, 0.9 },
                { 4, 0.8 },
                { 5, 0.75 }
            };
            return discount[count];
        }

        /// <summary>
        /// 取得每一集買特定本數的集數。
        /// </summary>
        /// <param name="order">訂單。</param>
        /// <param name="quantity">購買的本數。</param>
        /// <returns></returns>
        private int GetAdditionalVolumesCount(List<PotterSeries> order, int quantity)
        {
            var additionalBooks = order.Count(x => x.Quantity >= quantity);

            return additionalBooks;
        }
    }
}
