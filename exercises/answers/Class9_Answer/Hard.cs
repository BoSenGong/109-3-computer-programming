using System;
namespace Class9
{
    class Hard
    {
        public static void Reverse()
        {// 拿來公布的解答
            string[] nums = Console.ReadLine().Split(" ");
            bool[] isEven = new bool[30];
            // 可以改用List取代array，這樣就不用先宣告大小。
            int step = 0;
            int a = int.Parse(nums[0]), b = int.Parse(nums[1]);
            while(a != 1 || b != 1)
            {
                if(a > b)
                {
                    a -= b;
                    isEven[step] = true;
                }
                else
                {
                    (a, b) = (b, a);
                    isEven[step] = false;
                }
                step++;                
            }
            // a_k = a_k / b_k, k就是編號
            int k = 1;
            for(int i = step-1; i >= 0; i--)
            {
                if (isEven[i])
                {
                    k *= 2;
                }
                else
                {
                    k ++;
                }
            }
            Console.WriteLine(k);
        }

        public static string Forward(int k)
        {// 可以拿來出測資指定編號k，會給出題目所需要的兩個數
            if(k == 1) return "1 1";
            else
            {
                int a = 0, b = 0;
                if(k % 2 == 0)
                {
                    string[] str = Forward(k/2).Split(" ");
                    a = int.Parse(str[0]);
                    b = int.Parse(str[1]);
                    a += b;
                    return a.ToString() + " " + b.ToString();
                }
                else
                {
                    string[] str = Forward(k-1).Split(" ");
                    a = int.Parse(str[0]);
                    b = int.Parse(str[1]);
                    (a, b) = (b, a);
                    return a.ToString() + " " + b.ToString();
                }
            }
        }

        
    }

}
        
