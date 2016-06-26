public class Solution {
    public string RemoveDuplicateLetters(string s) {
        if(s==null || s.Length==0) return "";
        int[] nums = new int[26];
        bool[] visited = new bool[26];
        for(int i=0; i<s.Length; i++){
            nums[s[i]-'a'] ++;
        }
        
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<s.Length; i++){
            int index = s[i]-'a';
            nums[index]--;
            if(visited[index]) continue;
            
            while(sb.Length>0 && s[i]<sb[sb.Length-1] && nums[sb[sb.Length-1]-'a']>0){
                visited[sb[sb.Length-1]-'a'] = false;
                sb.Remove(sb.Length-1, 1);
            }
            sb.Append(s[i]);
            visited[index] = true;
        }

        return sb.ToString();
    }

}