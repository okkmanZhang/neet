public class _242ValidAnagram {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;
 
        Dictionary<char, int> sx = new Dictionary<char, int>();        
        Dictionary<char, int> tx = new Dictionary<char, int>();      

        for (int i = 0; i < s.Length; i++)
        {
            if (sx.Keys.Contains(s[i]))
            {
                sx[s[i]]++;
            } else {
                sx.Add(s[i], 1);
            }

            if (tx.Keys.Contains(t[i]))
            {
                tx[t[i]]++;
            } else {
                tx.Add(t[i], 1);
            }            
        }

        foreach(var v in sx.Keys){
            if(!tx.Keys.Contains(v) || tx[v] != sx[v])
            {
                return false;
            }
        }


        return true;
    }
}