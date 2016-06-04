public class Solution {
    public bool WordPattern(string pattern, string str) {
        var dict = new Dictionary<string,char>();
        var dict2 = new Dictionary<char, string>();
        var strs = str.Split();
        if(pattern.Length!=strs.Length) return false;
        for(int i=0; i<strs.Length; i++){
            if(dict.ContainsKey(strs[i]) && dict[strs[i]] != pattern[i] || 
                dict2.ContainsKey(pattern[i]) && dict2[pattern[i]] != strs[i])
                return false;
            if(!dict.ContainsKey(strs[i]) ){
                dict[strs[i]] = pattern[i];
            } 
            if(!dict2.ContainsKey(pattern[i]))
                dict2[pattern[i]] = strs[i];
        }
        return true;
    }
}