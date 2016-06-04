public class Solution {
    public string GetHint(string secret, string guess) {
        var table1 = new Dictionary<int, int>();
        var table2 = new Dictionary<int, int>();
        int A = 0, B=0;
        for(int i=0; i<secret.Length; i++){
            int d1 = secret[i];
            int d2 = guess[i];
            if(d1==d2) A++;
            else {
                if(table1.ContainsKey(d2) && table1[d2]>0){
                    B++;
                    table1[d2]--;
                } else if(table2.ContainsKey(d2)) {
                    table2[d2]++;
                } else {
                    table2[d2] = 1;
                }
                if(table2.ContainsKey(d1) && table2[d1]>0){
                    B++;
                    table2[d1]--;
                } else if(table1.ContainsKey(d1)) {
                    table1[d1]++;
                } else {
                    table1[d1] = 1;
                }
            }
        }
        
        return string.Format("{0}A{1}B", A, B);
    }
}