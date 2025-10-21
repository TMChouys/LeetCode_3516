namespace LeetCode_3516
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程

            Console.WriteLine("Enter the position of Person 1:"); //提示使用者輸入Person 1的位置
            string str1 = Console.ReadLine(); //讀取使用者輸入的字串並存放在str1變數的初值
            int a = Convert.ToInt32(str1); //將str1字串轉換為整數並存放在a變數的初值

            Console.WriteLine("Enter the position of Person 2:"); //提示使用者輸入Person 2的位置
            string str2 = Console.ReadLine(); //讀取使用者輸入的字串並存放在str2變數的初值
            int b = Convert.ToInt32(str2); //將str2字串轉換為整數並存放在b變數的初值

            Console.WriteLine("Enter the position of Person 3:"); //提示使用者輸入Person 3的位置
            string str3 = Console.ReadLine(); //讀取使用者輸入的字串並存放在str3變數的初值
            int c = Convert.ToInt32(str3); //將str3字串轉換為整數並存放在c變數的初值

            Console.WriteLine("Which person reaches Person 3 first? If the answer is 0 that means both arrive at the same time."); //提示使用者輸入Person 3的位置
            Console.WriteLine(FindClosest(a, b, c));  //呼叫擁有參數和傳回值FindClosest函數並將a、b、c引數傳給形式參數x, y, z，經過函數運算後傳回值輸出到主控台
            Console.ReadLine(); //等待使用者按下Enter鍵後結束程式

            /*
            LeetCode 3516. Find Closest Person

            You are given three integers x, y, and z, representing the positions of three people on a number line:

            x is the position of Person 1.
            y is the position of Person 2.
            z is the position of Person 3, who does not move.
            Both Person 1 and Person 2 move toward Person 3 at the same speed.

            Determine which person reaches Person 3 first:

            Return 1 if Person 1 arrives first.
            Return 2 if Person 2 arrives first.
            Return 0 if both arrive at the same time.
            Return the result accordingly.

            Example 1:
            Input: x = 2, y = 7, z = 4
            Output: 1
            Explanation:
            Person 1 is at position 2 and can reach Person 3 (at position 4) in 2 steps.
            Person 2 is at position 7 and can reach Person 3 in 3 steps.
            Since Person 1 reaches Person 3 first, the output is 1.

            Example 2:
            Input: x = 2, y = 5, z = 6
            Output: 2
            Explanation:
            Person 1 is at position 2 and can reach Person 3 (at position 6) in 4 steps.
            Person 2 is at position 5 and can reach Person 3 in 1 step.
            Since Person 2 reaches Person 3 first, the output is 2.

            Example 3:
            Input: x = 1, y = 5, z = 3
            Output: 0
            Explanation:
            Person 1 is at position 1 and can reach Person 3 (at position 3) in 2 steps.
            Person 2 is at position 5 and can reach Person 3 in 2 steps.
            Since both Person 1 and Person 2 reach Person 3 at the same time, the output is 0.

            Constraints:
            1 <= x, y, z <= 100

            LeetCode 3516. 尋找最近的人

            給定三個整數 x、y 和 z，分別代表三個人在數軸上的位置：

            x 表示人 1 的位置。
            y 表示人 2 的位置。
            z 表示人 3 的位置，人 3 不動。
            人 1 和人 2 都以相同的速度向人 3 移動。

            判斷哪個人先到達人 3：

            如果人 1 先到達，則回傳 1。
            如果人 2 先到達，則回傳 2。
            如果兩人同時到達，則返回 0。
            傳回相應的結果。

            範例 1：
            輸入：x = 2, y = 7, z = 4
            輸出：1
            解釋：
            人 1 在位置 2，兩步即可到達人 3（在位置 4）。
            人 2 在位置 7，三步即可到達人 3。
            由於人 1 先到達人 3，因此輸出為 1。

            範例 2：
            輸入：x = 2, y = 5, z = 6
            輸出：2
            解釋：
            人 1 位於位置 2，需要 4 步驟才能到達人 3（位於位置 6）。
            人 2 位於位置 5，需要 1 步才能到達人 3。
            由於人 2 先到達人 3，因此輸出為 2。

            範例 3：
            輸入：x = 1, y = 5, z = 3
            輸出：0
            解釋：
            人 1 位於位置 1，需要 2 步驟才能到達人 3（位於位置 3）。
            人 2 位於位置 5，需要 2 步才能到達人 3。
            由於人物 1 和人物 2 同時到達人物 3，因此輸出為 0。

            限制：
            1 <= x, y, z <= 100
             */

            //知識點：Ch7 函數，建立C#函數、函數的參數列、函數的傳回值、區域函數
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、算術運算⼦
            //知識點：Ch5 選擇控制項與條件敘述，關係運算子、if單選條件敘述

            //解題思路
            //區域函數
            //1.傳回值是整數資料型別 int 1表示P1先到P3、2表示P2先到P3、0表示P1與P2同時到P3
            //2.形式變數是三個個整數資料型別 int x, int y, int z 表示P1、P2、P3的位置
            int FindClosest(int x, int y, int z)
            {
                //1. 輸入
                //輸入形式變數轉換成距離
                int dX = x - z; //宣告整數變數 dX 並指定初值為 x - z 表示x與z的距離
                int dY = y - z; //宣告整數變數 dY 並指定初值為 y - z 表示y與z的距離

                //2. 處理
                if (dX < 0) dX = -dX; //如果 dX 小於 0，表示 x 在 z 的左邊，將 dX 取相反數，變成正值代替使用取絕對值的方法，if單選條件敘述的單行無括號表示法
                if (dY < 0) dY = -dY; //如果 dY 小於 0，表示 y 在 z 的左邊，將 dY 取相反數，變成正值代替使用取絕對值的方法，if單選條件敘述的單行無括號表示法

                //3. 輸出
                // if/else/if 多選⼀條件敘述，有括號表示法
                if (dX < dY) //如果 dX 小於 dY，表示 x 比 y 更接近 z
                {
                    return 1; //回傳 1，表示 Person 1 先到達 Person 3
                }
                else if (dX > dY) //否則如果 dX 大於 dY，表示 y 比 x 更接近 z
                {
                    return 2; //回傳 2，表示 Person 2 先到達 Person 3
                }
                else //否則表示 dX 等於 dY，表示 x 與 y 距離 z 相同
                {
                    return 0; //回傳 0，表示 Person 1 與 Person 2 同時到達 Person 3
                }

            }
            //結束簽名ChouYS
        }
    }
}
