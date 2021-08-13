/*
Day14 (4/8)
Runtime PR: 94.38
Memory PR: 81.95
List is fast!
*/
public class Solution {
    public bool IsValid(string s) {
        List<char> bras = new List<char>(){};
        int layer = -1;
        for(int i = 0; i < s.Length; i++){
            if(IsBra(s[i])){
                layer++;
                bras.Add(s[i]);
            }
            else{
                if(layer<0) return false;
                if(bras[bras.Count-1]==ToSet(s[i])){
                    layer--;
                    bras.RemoveAt(bras.Count-1);
                }
                else return false;
            }
        }
        return (layer==-1)?true:false;
        char ToSet(char c){
            switch(c){
                case ')':
                return '(';
                case '}':
                return '{';
                default :
                return '[';
            }
        }

        bool IsBra(char c) {
            switch(c){
                case '(':
                return true;
                case '{':
                return true;
                case '[':
                return true;
                case ')':
                return false;
                case '}':
                return false;
                default:
                return false;
            }
        }
    }
}
