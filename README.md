# TDD第二週作業

#### [作業說明](https://github.com/kcwang-tw/TDD-DayTwo/blob/master/PotterShoppingCart.Tests/User%20Story.txt)

#### Step
#####1. [新增測試案例且執行後亮紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/8a4d50fbb8e4e3d317eaf748ccc431203e8dd3da)

#####2. [測試案例1：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/79e60eaf6fb85ebaf951f43848fa59a959acd8a3)
- 情境：第一集買了一本，其他都沒買，價格應為100 × 1=100元
- 新增production code，通過測試

#####3. [測試案例2：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/0fb7af6254d3b79f4268022bad88c128c58fab56)
- 情境：第一集買了一本，第二集也買了一本，價格應為100 × 2 × 0.95 = 190
- 價錢不對，測試失敗

#####4. [測試案例2：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/6e852bcc3aec4e044032adae0ff83c62043a24a6)
- 增加折扣數判斷
- 價錢符合，測試通過

#####5. [測試案例3：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/3eac26eb7bcaf35cde89f13b34d7a537249436c4)
- 情境：一二三集各買了一本，價格應為100 × 3 × 0.9 = 270
- 價錢不對，測試失敗

#####6. [測試案例3：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/e560e7ab372d9bf1af3d0c3cfa850e21e6dac4e3)
- 修改折扣規則
- 價錢符合，測試通過

#####7. [測試案例4：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/7f1bd57494e368e9f0ec360dbd8d361460f534f0)
- 情境：一二三四集各買了一本，價格應為100 × 4 × 0.8 = 320
- 價錢不對，測試失敗

#####8. [測試案例4：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/ce71882b4123a3764787218f720c2e5812102bd2)
- 把折扣寫進dictionary對應
- 價錢符合，測試通過

#####9. [測試案例5：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/e63f307138548bb75bf7199c1aa7e97fec1cb085)
- 情境：一次買了整套，一二三四五集各買了一本，價格應為100 × 5 × 0.75 = 375
- 價錢不對，測試失敗

#####10. [測試案例5：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/651af9c91b6ab514760ac65b2229d5f447b6b784)
- 折扣dictionary增加購買五本書的對應折扣
- 價錢符合，測試通過

#####11. [測試案例6：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/d200c68acdddb2ab82cfada6fc70811b3aa67c10)
- 情境：一二集各買了一本，第三集買了兩本，價格應為100 × 3 × 0.9 + 100 = 370
- 價錢不對，測試失敗

#####12. [測試案例6：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/3ce9d91afd0ab07be31d01d502ef609928a32c3f)
- 增加同一集多買數量判斷並更改折扣計算公式
- 價錢符合，測試通過

#####13. [重構](https://github.com/kcwang-tw/TDD-DayTwo/commit/2be18213ddd99a272ecc468a11300ed06cb3785e)
- 調整變數命名以符合語意
- 擷取方法，計算單集多買的數量

#####14. [重構](https://github.com/kcwang-tw/TDD-DayTwo/commit/b04cca04ae5c43e1a967f3112ec60251764f4bb8)
- 擷取方法，計算折扣
- 簡化GetAdditionalCount，改為lambda寫法

#####15. [測試案例7：紅燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/3ce9d91afd0ab07be31d01d502ef609928a32c3f)
- 情境：第一集買了一本，第二三集各買了兩本，價格應為100 × 3 × 0.9 + 100 × 2 × 0.95 = 460
- 價錢不對，測試失敗

#####16. [測試案例7：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/b6b1a6193850536f5a77321527ddebb99dda77e6)
- 改寫數量計算方法，取得同一集購買了X本的集數
- 變更金額計算公式
C. 價錢符合，測試通過

#####17. [測試案例8：綠燈](https://github.com/kcwang-tw/TDD-DayTwo/commit/8a4d50fbb8e4e3d317eaf748ccc431203e8dd3da)
- 自訂情境：第一集買一本，第二四集各買了三本，第三集買兩本，價格應為100 × 4 × 0.8 + 100 × 3 × 0.9 + 100 × 2 × 0.95 = 780
- 測試通過
