public class Solution {
    public string RemoveDuplicateLetters(string s) {
        if(s==null || s.Length==0) return "";
        int[] nums = new int[26];
        for(int i=0; i<s.Length; i++){
            nums[i] = -1;
        }
        
        char[] chars = s.ToCharArray();
        for(int i=0; i<chars.Length; i++){
            if(nums[s[i]-'a']>=0){
                int lastpos = nums[s[i]-'a'];
                if(s[lastpos]>s[lastpos+1]){
                    chars[lastpos] = '0';
                    nums[s[i]-'a'] = i;
                } else{
                    chars[i] = '0';
                }
            } else {
                nums[s[i]-'a'] = i;
            }
        }
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<chars.Length; i++){
            if(chars[i] != '0')
                sb.Append(chars[i]);
        }
        return sb.ToString();
    }
}