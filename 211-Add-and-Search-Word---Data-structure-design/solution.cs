public class WordDictionary {
    private class TrieNode {
        public TrieNode[] nodes;
        public bool marked = false;
        public TrieNode(){
            nodes = new TrieNode[26];
        }
    }
    
    private TrieNode root;
    public WordDictionary(){
        root = new TrieNode();
    }

    // Adds a word into the data structure.
    public void AddWord(String word) {
        if(string.IsNullOrEmpty(word)) return;
        var preNode = root;
        foreach(char c in word){
            if(preNode.nodes[c-'a']==null){
                preNode.nodes[c-'a'] = new TrieNode();
            } 
            preNode = preNode.nodes[c-'a'];
        }
        preNode.marked = true;
    }

    // Returns if the word is in the data structure. A word could
    // contain the dot character '.' to represent any one letter.
    public bool Search(string word) {
        if(string.IsNullOrEmpty(word)) return false;
        return Search(word, -1, root);
    }
    
    private bool Search(string word, int pos, TrieNode node){
        if(pos>=word.Length || node==null) return false;
        
        if(pos==word.Length-1) return node.marked;
        pos += 1;
        if(word[pos]!='.'){
            if(Search(word, pos, node.nodes[word[pos]-'a'])) return true;
        } else{
            if(node.nodes.Any(x => Search(word, pos, x))) return true;
        }
        return false;
    }
}

// Your WordDictionary object will be instantiated and called as such:
// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.AddWord("word");
// wordDictionary.Search("pattern");