public class Solution {
    public boolean isValid(String s) {
        if (s == null || s.length() == 0) return true;
        
        Stack<Character> stack = new Stack<>();
        
        for (int i=0; i<s.length(); i++) {
            char c = s.charAt(i);
            switch (c) {
                case ')':
                    if(stack.isEmpty()) return false;
                    char other = stack.pop();
                    if (other != '(') return false;
                    break;
                case ']':
                    if(stack.isEmpty()) return false;
                     other = stack.pop();
                    if (other != '[') return false;
                    break;
                case '}':
                    if(stack.isEmpty()) return false;
                     other = stack.pop();
                    if (other != '{') return false;
                    break;
                default:
                    stack.push(c);
                    break;
            }
        }
        
        return stack.isEmpty();
    }
}