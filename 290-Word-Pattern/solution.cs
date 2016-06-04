public class Solution {
    public bool WordPattern(string pattern, string str) {
        var dict = new Dictionary<string,char>();
        var strs = str.Split();
        for(int i=0; i<strs.Length; i++){
            if(!dict.ContainsKey(strs[i])){
                dict[strs[i]] = pattern[i];
            } else if(dict[strs[i]] != pattern[i])
                return false;
        }
        return true;
    }
}