public class Solution {
    public string GetHint(string secret, string guess) {
        if(secret.Length==0) return "0A0B";
        var table = new int[10];
        int a = 0, b=0;
        for(int i=0; i<secret.Length; i++){
            int d1 = secret[i]-'0';
            int d2 = guess[i]-'0';
            if(d1==d2) a++;
            else {
                if(table[d1]++<0)   b++;
                if(table[d2]-->0) b++;
            }
        }
        
        return string.Format("{0}A{1}B", a, b);
    }
}