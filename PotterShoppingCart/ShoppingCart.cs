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
            int tatal = order.Sum(x => x.Quantity);

            // 計算單集多買的數量
            int additionalCount = GetAdditionalCount(order);

            int eachVolumesCount = tatal - additionalCount;

            Dictionary<int, double> discount = new Dictionary<int, double>
            {
                { 1, 1 },
                { 2, 0.95 },
                { 3, 0.9 },
                { 4, 0.8 },
                { 5, 0.75 }
            };

            return (int)(100 * eachVolumesCount * discount[eachVolumesCount] + 100 * additionalCount);
        }

        /// <summary>
        /// 取得每一集多買的本數。
        /// </summary>
        /// <param name="order">訂單。</param>
        /// <returns></returns>
        private int GetAdditionalCount(List<PotterSeries> order)
        {
            int additionalCount = 0;
            foreach (var item in order)
            {
                if (item.Quantity > 1)
                    additionalCount++;
            }
            return additionalCount;
        }
    }
}
