# Class 11 Exercise

## **Q1:**

1. 如何宣告一維陣列？

   (A)  int[] a = new int[10];
   
   (B)  int a = new int[10];
   
   (C)  int a[] = new int[10];
   
   (D)  int a[10] = new int[10];
   
   
   
2. 無參數的Random()函式使用下列何者來產生它的種子值？

   (A)  記憶體地址

   (B)  系統時鐘

   (C)  編譯環境

   

3. 何者不是工程方法的要點？

   (A) 辨識問題核心

   (B) 訂定優先順序

   (C) 思考解決方案

   (D) 逐步演化

## **Q2: Anagrams**

Write a program that tests whether two words are anagrams.

### Sample Input and Output: ###
```
Enter first word:smartest
Enter second word:mattress
The words are anagrams.
```

```
Enter first word:dumbest
Enter second word:stumble
The words are not anagrams.
```

## **Q3: Find root**

Find the root of the following function by any method you come out with. \
The deviation between your answer and the correct answer(see Note.) should be smaller than 0.0001.

1. ![f1](https://imgur.com/nqOzZtK.jpg)
2. ![f2](https://imgur.com/Y6iRVG1.jpg)
3. ![f3](https://imgur.com/7SwhMqQ.jpg)
4. ![f4](https://imgur.com/cgfVGv9.jpg)
5. ![f5](https://imgur.com/DOKLFDf.jpg)

#### Note: Approximate Root
1.  2.0000
2.  1.2599
3.  2.0739
4.  1.6490
5.  3.2216

### Output: ###
```
f1's root at x = 1.99991234
f2's root at x = 1.25995678
f3's root at x = 2.07399012
f4's root at x = 1.64903456
f5's root at x = 3.22167890
```

***DO NOT USE*** something like 
```
...
if (myAns - noteAns < 0.001)
{
    Console.WriteLine(myAns)
    break;
}
...
```

#### Hint:
1. [Root-finding algorithms](https://en.wikipedia.org/wiki/Root-finding_algorithms)
2. 如果你真的毫無想法，可以參考高中曾經學過的[勘根定理](http://web.ntnu.edu.tw/~algo/RootFinding.html)，想辦法用程式來實作
