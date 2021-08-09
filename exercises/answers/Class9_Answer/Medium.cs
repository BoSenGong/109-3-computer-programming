using System;
namespace class9
{
    class Medium
    {
        public static void Run()
        {
            string equation = Console.ReadLine();
            char separator;
            if (equation.Contains('+')) { separator = '+'; }
            else if (equation.Contains('-')) { separator = '-'; }
            else if (equation.Contains('*')) { separator = '*'; }
            else if (equation.Contains('/')) { separator = '/'; }
            else {return;}
            string[] nums = equation.Split(separator);
            int num0, num1;
            string result = "";
            num0 = int.TryParse(nums[0], out num0)?int.Parse(nums[0]):Easy.Roman2Arabic(nums[0]);
            num1 = int.TryParse(nums[1], out num1)?int.Parse(nums[1]):Easy.Roman2Arabic(nums[1]);
            switch (separator)
            {
                case '+':
                result = Easy.Arabic2Roman(num0 + num1);
                break;
                case '-':
                result = Easy.Arabic2Roman(num0 - num1);
                break;
                case '*':
                result = Easy.Arabic2Roman(num0 * num1);
                break;
                case '/':
                result = Easy.Arabic2Roman(num0 / num1);
                break;
            }
            Console.WriteLine(result==""?"zero":result);
        }
    }

}
        
