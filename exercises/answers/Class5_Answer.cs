

























static void Q3_AsciiCodeConverter()
{
    Console.WriteLine("Input a character then press Enter:");
    string input = Console.ReadLine();
    if (input.Length != 1) 
    { // 判斷使用者是否僅輸入一個字元
        Console.WriteLine("Invalid input."); 
        return; // return代表了函式就此結束，同學可以善用return。
    }
    int asciiCode = (int)input[0];
    Console.WriteLine("{0}'s ascii code is {1}", input, asciiCode);
    if (asciiCode >= 48 && asciiCode <= 57)
    {
        Console.WriteLine("This character is a number");
    }
    else if (asciiCode >= 65 && asciiCode <= 90)
    {
        Console.WriteLine("This character is an upper letter");
    }
    else if (asciiCode >= 97 && asciiCode <= 122)
    {
        Console.WriteLine("This character is a lower letter");
    }
    else Console.WriteLine("This character is a symbol");
}
