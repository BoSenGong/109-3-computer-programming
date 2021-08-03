# Class 9 Exercise

## Easy
#### Question: Roman-Arabic Converter
If input is a Arabic Number, convert it to a Roman Number. \
Or convert a Roman Number to an Arabic Number.

Convert table:[wiki](https://en.wikipedia.org/wiki/Roman_numerals)

#### Example:
```
777
DCCLXXVII
```
```
DCLXVI
666
```
```
7414
_VMMCDXIV
```
"_" means:1000*...

eg:

_V = 1000 * 5 = 5000

_M = 1000 * 1000 = 1000000


## Medium
#### Question: Roman Numeral Calculator
Make a caculator which can deal with Roman Numeral and Arabic Numeral.
#### Example:
```
I-1
zero
```
means: 1-1 = 0
```
MMMCCCXXX/II
MDCLXV
```
means: 3330/2 = 1665
```
CCCXXXIII*III
CMXCIX
```
means: 333*3 = 999
```
DXLIII+CXXIII
DCLXVI
```
means: 543+123 = 666


## Hard
#### Question: Zerojudge_b537

題目連結請參考:[link](https://zerojudge.tw/ShowProblem?problemid=b537) \
因為我沒梗了，只能出這種題目。

### Note:
1. 你不用考慮EOF的問題，只要根據輸入的兩個數字，印出相對應的編號即可。
2. 你不用考慮編號>2,147,483,647的狀況，批改測資的編號不會超過這個。
#### Example:
```
4 3
10
```
```
30 11
236
```
```
8 9
259
```
```
11 25
229
```
```
22 15
522
```
```
17 18
131075
```

### Hint:
1. 善用 bool array
2. 善用 array 的 index 順序
3. 你必須清楚理解，你到底可以用/想用你擁有的變數，來做什麼事情，並且妥善安排各步驟的順序。
4. 不要覺得超出範圍，這題只要會if else跟array就能寫了。
