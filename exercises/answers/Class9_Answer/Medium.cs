using System;
namespace grading
{
    class Medium
    {
        public static void Run()
        {
            string equation = Console.ReadLine();
            if (equation.Contains('+'))
            {
                string[] nums = equation.Split('+');
                int num0, num1;
                num0 = int.TryParse(nums[0], out num0)?int.Parse(nums[0]):Easy.Roman2Arabic(nums[0]);
                num1 = int.TryParse(nums[1], out num1)?int.Parse(nums[1]):Easy.Roman2Arabic(nums[1]);
                Console.WriteLine(Easy.Arabic2Roman(num0+num1)); 
            }
            else if (equation.Contains('-'))
            {
                string[] nums = equation.Split('-');
                int num0, num1;
                num0 = int.TryParse(nums[0], out num0)?int.Parse(nums[0]):Easy.Roman2Arabic(nums[0]);
                num1 = int.TryParse(nums[1], out num1)?int.Parse(nums[1]):Easy.Roman2Arabic(nums[1]);
                string result = Easy.Arabic2Roman(num0-num1);
                Console.WriteLine(result==""?"zero":result);
            }
            else if (equation.Contains('*'))
            {
                string[] nums = equation.Split('*');
                int num0, num1;
                num0 = int.TryParse(nums[0], out num0)?int.Parse(nums[0]):Easy.Roman2Arabic(nums[0]);
                num1 = int.TryParse(nums[1], out num1)?int.Parse(nums[1]):Easy.Roman2Arabic(nums[1]);
                Console.WriteLine(Easy.Arabic2Roman(num0*num1)); 
            }
            else if (equation.Contains('/'))
            {
                string[] nums = equation.Split('/');
                int num0, num1;
                num0 = int.TryParse(nums[0], out num0)?int.Parse(nums[0]):Easy.Roman2Arabic(nums[0]);
                num1 = int.TryParse(nums[1], out num1)?int.Parse(nums[1]):Easy.Roman2Arabic(nums[1]);
                string result = Easy.Arabic2Roman(num0/num1);
                Console.WriteLine(result==""?"zero":result);
            }
        }
    }

}
        