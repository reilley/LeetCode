public class Solution {
    private char[][] _table;
    public List<String> findWords(char[][] board, String[] words) {
        ArrayList<String> list = new ArrayList<String>();
        if(board==null || board.length==0 || words == null || words.length==0) return list;
        
        // build Tries
        int m = board.length;
        int n = board[0].length;
        _table = new char[m][n];
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                _table[i][j] = board[i][j];
            }
        }
        TrieNode root = new TrieNode();
        for(int i=0; i<board.length; i++){
            for(int j=0; j<board[0].length; j++){
                buildTrie(i, j, root);
            }
        }
        
        //searching 
        HashSet<String> searched = new HashSet<String>();
        for(String word : words){
            if(searched.contains(word)) continue;
            //char[] carr = word.toCharArray();
            if(search(root, word, 0)) 
                list.add(word);
            searched.add(word);
        }
        return list;
    }
    
    private boolean search(TrieNode cur, String word, int k){
        if(cur == null || cur.val=='\0') return false;
        //if( k>= word.length) return true;
        char c = word.charAt(k);
        if(cur.val==c && k == word.length()-1) return true;
        if(c < cur.val) 
            return search(cur.left, word, k);
        else if(c>cur.val) 
            return search(cur.right, word, k);
        else 
            return search(cur.mid, word, k+1);
    }
    
    private void buildTrie(int i, int j, TrieNode node){
        if(i<0 || j<0 || i>= _table.length || j>=_table[0].length || _table[i][j]=='#') return;
        char c = _table[i][j];
        int k = c -'a';

        TrieNode cur = node;
        TrieNode parent = cur;
            int dir = 0;
            while(cur==null || cur.val != c){
                if(cur == null) {
                    cur = new TrieNode(c);
                    if(dir==1) parent.left = cur;
                    else if(dir==2) parent.right = cur;
                    else
                        parent.mid = cur;
                }else if(cur.val=='\0') {
                    cur.val = c;
                    dir = 0;
                }
                else if(c < cur.val){
                    parent = cur;
                    cur = cur.left;
                    dir = 1;
                } else{
                    parent = cur;
                    cur = cur.right;
                    dir = 2;
                }
            } 
        
        
        if(cur.mid==null)
            cur.mid = new TrieNode();
        cur = cur.mid;
        

        _table[i][j]='#';
        if(i>0)
            buildTrie(i-1, j, cur);
        if(i<_table.length-1)
            buildTrie(i+1, j, cur);
        if(j>0)
            buildTrie(i, j-1, cur);
        if(j<_table[0].length-1)
            buildTrie(i, j+1, cur);
        _table[i][j]=c;   
    }
    
    
    private class TrieNode{
        public TrieNode left, mid, right;
        public char val;
        public TrieNode(){ val='\0'; }
        public TrieNode(char v){
            val = v;
        }
    }
}