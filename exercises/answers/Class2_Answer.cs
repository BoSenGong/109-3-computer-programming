        static int Medium(){
            Boolean isEnd = false;
            Console.Write("temperature of Celsius:");
            try{
                double degreesCelsius = Double.Parse(Console.ReadLine());
                double degreesFahrenheit = 9.0/5 * degreesCelsius + 32;
                // 若為 9(int)/5(int) 會算出 1
                if(degreesFahrenheit < -459.67){
                    throw new ArgumentException();
                }
                if(degreesFahrenheit> 82.4){
                    Console.Write("It's hot!");
                }else if(degreesFahrenheit >59.00){
                    Console.Write("It's warm!");
                }else if(degreesFahrenheit > 50.00){
                    Console.Write("It's cool!");
                }else if(degreesFahrenheit > 41.00){
                    Console.Write("It's chilly!");
                }else if(degreesFahrenheit > 32.00){
                    Console.Write("It's cold!");
                }else{
                    Console.Write("It's freezing!");
                }
                isEnd = true;
            }catch(Exception e){}
            // try/throw-catch是一種很方便的語法，可以讓我們程式發生錯誤時，根據不同的exception做出不同的反應，而不是直接中斷。
            // 範例程式碼可以參考C# docs
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
            // try-catch是範圍外的內容，但使用他做例外處理真的非常方便。
            Console.Write(isEnd? "\nEnd" : "\nSomething wrong, please check.");
            // 可以善用\n來做換行，另有各式escape character
            // https://en.wikipedia.org/wiki/Escape_character
            return isEnd? 0 : -1;
            // 雖C#的Main可以宣告為void，但此範例的寫法，可以藉由回傳值為0/-1來判斷此程式的執行狀況。
        }
        static void Hard(){
            Console.WriteLine("Input formula:");
            string str = Console.ReadLine();
            decimal a = (int)Char.GetNumericValue(str[0]);
            decimal b = (int)Char.GetNumericValue(str[2]);
            if(str[1] == '+'){
                Console.WriteLine(a+b);
            }else if(str[1]=='-'){
                Console.WriteLine(a-b);
            }else if(str[1] == '*'){
                Console.WriteLine(a*b);
            }else if(str[1]=='/'){
                Console.WriteLine(a/b);
            }
             
        }
        static void Easy(){
            string seniorStudentString = "senior student";
            string juniorStudentString = "junior student";
            int myGrade = 4;
            decimal myTargetGPAofThisSemester = 4.3m;
            bool isSeniorStudent = myGrade > 2;
            if(isSeniorStudent){
                Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", seniorStudentString,  myTargetGPAofThisSemester);
            }else{
                 Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", juniorStudentString,  myTargetGPAofThisSemester);
           
            }

        }
        
