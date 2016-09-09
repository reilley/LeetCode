public class Solution {
    public String longestPalindrome(String s) {
        if (s == null || s.length() == 0) return "";
        
        String ans = "";
        char[] carr = s.toCharArray();
        for (int i = 0; i < s.length(); i++) {
            StringBuilder sb = new StringBuilder();
            sb.append(carr[i]);
            int j = i;
            while (j+1 < carr.length && carr[i] == carr[j+1]) {
                sb.append(carr[++j]);
            }
            
            helper(carr, i, j, sb);
            if (sb.length() > ans.length()) {
                ans = sb.toString();
            }
            i = j;
        }
        
        return ans;
    }
    
    private void helper(char[] carr, int left, int right, StringBuilder sb) {
        while (left > 0 && right < carr.length -1 && carr[left-1] == carr[right+1]) {
            sb.insert(0, carr[--left]);
            sb.append(carr[++right]);
        }
    }
}