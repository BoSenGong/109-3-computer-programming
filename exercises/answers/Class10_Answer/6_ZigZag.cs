// Method 1 is faster, I have no idea for the reason.
// Method 1
/*
 *  RunTime PR:81.76
 *  Memory PR:54.59
 */
public class Solution {
    public string Convert(string s, int numRows) {
        string[] ss = new string[numRows];
        int period = 2*numRows-2;
        for(int i = 0; i < s.Length; i++){
            int NO = (period==0)?0:(i%period);
            ss[(NO>=numRows)?(period-NO):NO]+=s[i];
        }
        string sss = "";
        foreach(string str in ss) sss+=str;
        return sss;
    }
}
// Method 2
/*
 *  RunTime PR:68.24
 *  Memory PR:69.29
 */
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows==1) return s;
        int T = numRows*2 - 2; // T:period
        int Tmax = s.Length/T;
        string ss = "";
        int[] bases = new int[Tmax+1];
        for(int i = 0; i <= Tmax; i++){
            bases[i] = i*T;
        }
        for(int i = 0; i < numRows; i++){
            if(i==0 || (i+1)==numRows){
                try{
                    foreach(int b in bases){
                        ss+=s[b+i];
                    }                                  
                }catch{}
            }else{
                try{
                    foreach(int b in bases){
                        ss+=s[b+i];
                        ss+=s[b-i+T];
                    }                                  
                }catch{}
            }
        }
        return ss;
    }
}
