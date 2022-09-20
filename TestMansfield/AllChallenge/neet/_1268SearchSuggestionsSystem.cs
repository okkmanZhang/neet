using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _1268SearchSuggestionsSystem
    {
        //linq
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> res = new List<IList<string>>();

            for (int i = 0; i < searchWord.Length; i++)
            {
                string curStr = searchWord.Substring(0, i + 1);

                res.Add(products.
                            Where(p => p.Length >= i + 1 && p.Substring(0, i + 1) == curStr)
                            .OrderBy(s => s)
                            .Take(3)
                            .ToList());
            }

            return res;
        }

        //trie
        public IList<IList<string>> SuggestedProductsTrie(string[] products, string searchWord)
        {
            Trie trie = new Trie();
            IList<IList<string>> res = new List<IList<string>>();

            foreach (var iStr in products)
            {
                trie.Insert(iStr);
            }

            string prefix = "";

            foreach (char ichar in searchWord)
            {
                prefix += ichar;
                res.Add(trie.GetWordsStartWith(prefix));
            }

            return res;
        }
    }

    public class TrieNode
    {
        public bool IsWord;
        public TrieNode[] Children;
        public TrieNode()
        {
            Children = new TrieNode[26];
            IsWord = false;
        }
    }

    public class Trie
    {
        TrieNode Root, Curr;
        List<string> resultBuffer;

        public Trie()
        {
            this.Root = new TrieNode();
        }
        public void Insert(string str)
        {
            Curr = Root;

            foreach (var iChar in str)
            {
                if (Curr.Children[iChar - 'a'] == null)
                    Curr.Children[iChar - 'a'] = new TrieNode();

                Curr = Curr.Children[iChar - 'a'];
            }

            Curr.IsWord = true;
        }

        public void DFSWithPrefix(TrieNode dfsCurr, string word)
        {
            if (resultBuffer.Count() == 3)
                return;
            if (dfsCurr.IsWord)
                resultBuffer.Add(word);

            for (char iChar = 'a'; iChar <= 'z'; iChar++)
            {
                if (dfsCurr.Children[iChar - 'a'] != null)
                    DFSWithPrefix(dfsCurr.Children[iChar - 'a'], word + iChar);
            }
        }

        public List<string> GetWordsStartWith(string prefix)
        {
            Curr = Root;
            resultBuffer = new List<string>();

            foreach (var iChar in prefix)
            {
                if (Curr.Children[iChar - 'a'] == null)
                    return resultBuffer;

                Curr = Curr.Children[iChar - 'a'];
            }

            DFSWithPrefix(Curr, prefix);

            return resultBuffer;
        }
    }


}
