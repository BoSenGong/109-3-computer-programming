using System;
namespace grading
{
    class Easy
    {
        public static void Easy_Converter()
        {
            string input = Console.ReadLine();
            int number;
            bool isArabic = int.TryParse(input, out number);
            if (isArabic)
            {
                Console.WriteLine(Arabic2Roman(number));
            }
            else
            {
                Console.WriteLine(Roman2Arabic(input));
            }
        }
        public static string Arabic2Roman(int arabicNumber)
        {// arabicNumber <= 7414
            string romanNumber = "";
            if (arabicNumber >= 5000)
            {
                romanNumber += "_V";
                arabicNumber -= 5000;
            }
            else if (arabicNumber >= 4000)
            {
                romanNumber += "M_V";
                arabicNumber -= 4000;
            }
            for (int i = arabicNumber/1000; i > 0; i--)
            {
                romanNumber += "M";
                arabicNumber -= 1000;
            }
            // deal with hudreds----------------------------------
            if (arabicNumber >= 900)
            {
                romanNumber += "CM";
                arabicNumber -= 900;
            }
            else if (arabicNumber >= 500)
            {
                romanNumber += "D";
                arabicNumber -= 500;
            }
            else if (arabicNumber >= 400)
            {
                romanNumber += "CD";
                arabicNumber -= 400;
            }
            for (int i = arabicNumber/100; i > 0; i--)
            {
                romanNumber += "C";
                arabicNumber -= 100;
            }
            // deal with tens---------------------------------
            if (arabicNumber >= 90)
            {
                romanNumber += "XC";
                arabicNumber -= 90;
            }
            else if (arabicNumber >= 50)
            {
                romanNumber += "L";
                arabicNumber -= 50;
            }
            else if (arabicNumber >= 40)
            {
                romanNumber += "XL";
                arabicNumber -= 40;
            }
            for (int i = arabicNumber/10; i > 0; i--)
            {
                romanNumber += "X";
                arabicNumber -= 10;
            }
            // deal with units---------------------------------
            if (arabicNumber >= 9)
            {
                romanNumber += "IX";
                arabicNumber -= 9;
            }
            else if (arabicNumber >= 5)
            {
                romanNumber += "V";
                arabicNumber -= 5;
            }
            else if (arabicNumber == 4)
            {
                romanNumber += "IV";
                arabicNumber -= 4;
            }
            for (int i = arabicNumber; i > 0; i--)
            {
                romanNumber += "I";
                arabicNumber -= 1;
            }
            return romanNumber;
        }
        public static int Roman2Arabic(string romanNumber)
        {// 參考作法
            int arabicNumber = 0;
            if (romanNumber.Contains("M_V"))
            {
                romanNumber = romanNumber.Replace("M_V","");
                arabicNumber += 4000;
            }
            else if (romanNumber.Contains("_V"))
            {
                romanNumber = romanNumber.Replace("_V","");
                arabicNumber += 5000;
            }
            while (romanNumber.Length!=0 && romanNumber[0]=='M')
            {
                // 每拿走一個 領頭的M 加一千
                romanNumber = romanNumber.Remove(0, 1);
                arabicNumber += 1000;
            }
            // deal with hudreds----------------------------------
            if (romanNumber.Contains("CM"))
            {
                romanNumber = romanNumber.Replace("CM","");
                arabicNumber += 900;
            }
            else if (romanNumber.Contains("CD"))
            {
                romanNumber = romanNumber.Replace("CD","");
                arabicNumber += 400;
            }
            else if (romanNumber.Contains("D"))
            {
                romanNumber = romanNumber.Replace("D","");
                arabicNumber += 500;
            }
            while (romanNumber.Length!=0 && romanNumber[0]=='C')
            {
                // 每拿走一個 領頭的C 加一百
                romanNumber = romanNumber.Remove(0, 1);
                arabicNumber += 100;
            }
            // deal with tens----------------------------------
            if (romanNumber.Contains("XC"))
            {
                romanNumber = romanNumber.Replace("XC","");
                arabicNumber += 90;
            }
            else if (romanNumber.Contains("XL"))
            {
                romanNumber = romanNumber.Replace("XL","");
                arabicNumber += 40;
            }
            else if (romanNumber.Contains("L"))
            {
                romanNumber = romanNumber.Replace("L","");
                arabicNumber += 50;
            }
            while (romanNumber.Length!=0 && romanNumber[0]=='X')
            {
                // 每拿走一個 領頭的X 加十
                romanNumber = romanNumber.Remove(0, 1);
                arabicNumber += 10;
            }
            // deal with units----------------------------------
            if (romanNumber.Contains("IX"))
            {
                romanNumber = romanNumber.Replace("IX","");
                arabicNumber += 9;
            }
            else if (romanNumber.Contains("IV"))
            {
                romanNumber = romanNumber.Replace("IV","");
                arabicNumber += 4;
            }
            else if (romanNumber.Contains("V"))
            {
                romanNumber = romanNumber.Replace("V","");
                arabicNumber += 5;
            }
            while (romanNumber.Length!=0 && romanNumber[0]=='I')
            {
                // 每拿走一個 領頭的I 加 1
                romanNumber = romanNumber.Remove(0, 1);
                arabicNumber += 1;
            }
            return arabicNumber;
        }
    }
}
        