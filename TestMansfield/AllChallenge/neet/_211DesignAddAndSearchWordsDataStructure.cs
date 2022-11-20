namespace ClassLibrary1
{
public class WordDictionary {

    TrieSet set = new TrieSet();
    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        set.Add(word);
    }
    
    public bool Search(string word) {
        return set.HasKeyWithPattern(word);
    }
}
}