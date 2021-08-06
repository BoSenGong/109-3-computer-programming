# Class 10 Exercise

#### Note
You don't need to print answer in your console,

just declare methods for each questions below.

#### Example:
```
static bool Easy(string s) { ... }
static string Medium(string s, int numRows) { ... }
static bool Hard(string s, string p) { ... }
```

## Easy
#### Question: LeetCode - Valid Parentheses
[link](https://leetcode.com/problems/valid-parentheses/) 

#### Example:
```
Input: s = "[{(([{}]))}]"
Output: true
```
```
Input: s = "()[]{}"
Output: true
```
```
Input: s = "(]"
Output: false
```
```
Input: s = "([)]"
Output: false
```
### Hint:
bracket : () or [] or {} \
bra : ( or [ or { \
ket : ) or ] or } \
s = "()[]{}" \
means: bra1()ket1 bra2[]ket2 bra3{}ket3 \
s = "([)]" \
means: bra1(  bra2[)ket1  ]ket2

## Medium
#### Question: LeetCode - Zig-Zag Conversion
[link](https://leetcode.com/problems/zigzag-conversion/) 

#### Example:
```
Input: s = "GodIsAGirl", numRows = 4
Output: "GGoAidsrIl"
```
```
Input: s = "DamDadiDo", numRows = 3
Output: "DaoaDdDmi"
```
### Hint:
Calculate the period of Zig-Zag by numRows


## Hard (beyond the course, challenge)
#### Question: LeetCode - Regular Expression Matching
[link](https://leetcode.com/problems/regular-expression-matching/)

#### Example:
```
Input: s = "HowDareYou", p = "Ho*"
Output: false
```
```
Input: s = "HowDareYou", p = "Ho.*"
Output: true
```
```
Input: s = "HowDareYou", p = ".*You"
Output: true
```
```
Input: s = "HowDareYou", p = "H.*o"
Output: false
```
