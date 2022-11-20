using System.Text;

namespace ClassLibrary1
{

    public class Trie
    {

        TrieSet set = new TrieSet();
        public Trie()
        {

        }

        public void Insert(string word)
        {
            set.Add(word);
        }

        public bool Search(string word)
        {
            return set.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return set.HasKeyWithPrefix(prefix);
        }
    }


    public class TrieSet
    {
        private readonly TrieMap<Object> map = new TrieMap<Object>();

        public void Add(string key)
        {
            map.Put(key, new Object());
        }
        public void Remove(string key)
        {
            map.Remove(key);
        }
        public bool Contains(string key)
        {
            return map.ContainsKey(key);
        }
        public string ShortestPrefixOf(string query)
        {
            return map.ShortestPrefixOf(query);
        }
        public string LongestPrefixOf(string query)
        {
            return map.LongestPrefixOf(query);
        }
        public List<string> KeysWithPrefix(string prefix)
        {
            return map.KeysWithPattern(prefix);
        }
        public bool HasKeyWithPrefix(string prefix)
        {
            return map.HasKeyWithPrefix(prefix);
        }
        public List<string> KeysWithPattern(string pattern)
        {
            return map.KeysWithPattern(pattern);
        }
        public bool HasKeyWithPattern(string pattern)
        {
            return map.HasKeyWithPattern(pattern);
        }
        public int Size()
        {
            return map.Size();
        }
    }

    public class TrieMap<V>
    {
        private const int R = 256;
        private int size = 0;

        private class TrieNode<V>
        {
            public V val = default(V);
            public TrieNode<V>[] children = new TrieNode<V>[256];
        }

        private TrieNode<V> root = null;
        public int Size()
        {
            return size;
        }

        public V Get(string key)
        {
            TrieNode<V> x = GetNode(root, key);

            if (x == null || x.val == null)
            {
                return default(V);
            }

            return x.val;
        }

        public bool ContainsKey(string key)
        {
            return Get(key) != null;
        }

        public bool HasKeyWithPrefix(string prefix)
        {
            return GetNode(root, prefix) != null;
        }

        public string ShortestPrefixOf(string query)
        {
            TrieNode<V> p = root;
            for (int i = 0; i < query.Length; i++)
            {
                if (p == null)
                {
                    return "";
                }
                if (p.val != null)
                {
                    return query.Substring(0, i);
                }
                char c = query[i];
                p = p.children[c];
            }

            if (p != null && p.val != null)
            {
                return query;
            }

            return "";
        }

        public string LongestPrefixOf(string query)
        {
            TrieNode<V> p = root;
            int max_len = 0;

            for (int i = 0; i < query.Length; i++)
            {
                if (p == null)
                {
                    break;
                }
                if (p.val != null)
                {
                    max_len = i;
                }
                char c = query[i];
                p = p.children[c];

            }

            if (p != null && p.val != null)
            {
                return query;
            }

            return query.Substring(0, max_len);
        }

        public List<string> KeysWithPrefix(string prefix)
        {
            List<string> res = new List<string>();
            TrieNode<V> x = GetNode(root, prefix);
            if (x == null)
            {
                return res;
            }

            Traverse(x, new StringBuilder(prefix), res);
            return res;
        }

        public List<string> KeysWithPattern(string pattern)
        {
            List<string> res = new List<string>();
            Traverse(root, new StringBuilder(), pattern, 0, res);
            return res;
        }

        public bool HasKeyWithPattern(string pattern)
        {
            return HasKeyWithPattern(root, pattern, 0);
        }

        public void Put(string key, V val)
        {
            if (!ContainsKey(key))
            {
                size++;
            }
            root = Put(root, key, val, 0);
        }

        public void Remove(string key)
        {
            if (!ContainsKey(key))
            {
                return;
            }
            root = Remove(root, key, 0);
            size--;
        }

        private TrieNode<V> Remove(TrieNode<V> node, string key, int i)
        {
            if (node == null)
            {
                return null;
            }
            if (i == key.Length)
            {
                node.val = default(V);
            }
            else
            {
                char c = key[i];
                node.children[c] = Remove(node.children[c], key, i + 1);
            }

            if (node.val != null)
            {
                return node;
            }
            for (int c = 0; c < R; c++)
            {
                if (node.children[c] != null)
                {
                    return node;
                }
            }
            return null;
        }
        private TrieNode<V> Put(TrieNode<V> node, string key, V val, int i)
        {
            if (node == null)
            {
                node = new TrieNode<V>();
            }
            if (i == key.Length)
            {
                node.val = val;
                return node;
            }
            char c = key[i];
            node.children[c] = Put(node.children[c], key, val, i + 1);
            return node;
        }

        private bool HasKeyWithPattern(TrieNode<V> node, string pattern, int i)
        {
            if (node == null)
            {
                return false;
            }
            if (i == pattern.Length)
            {
                return node.val != null;
            }
            char c = pattern[i];
            if (c != '.')
            {
                return HasKeyWithPattern(node.children[c], pattern, i + 1);
            }
            for (int j = 0; j < R; j++)
            {
                if (HasKeyWithPattern(node.children[j], pattern, i + 1))
                {
                    return true;
                }
            }
            return false;
        }

        private void Traverse(TrieNode<V> node, StringBuilder path, string pattern, int i, List<string> res)
        {
            if (node == null)
            {
                return;
            }
            if (i == pattern.Length)
            {
                if (node.val != null)
                {
                    res.Add(path.ToString());
                }
                return;
            }
            char c = pattern[i];
            if (c == '.')
            {
                for (char j = (char)0; j < R; j++)
                {
                    path.Append(j);
                    Traverse(node.children[j], path, pattern, i + 1, res);
                    path.Remove(path.Length - 1, 1);
                }
            }
            else
            {
                path.Append(c);
                Traverse(node.children[c], path, pattern, i + 1, res);
                path.Remove(path.Length - 1, 1);
            }
        }

        private void Traverse(TrieNode<V> node, StringBuilder path, List<string> res)
        {
            if (node == null)
            { return; }

            if (node.val != null)
            {
                res.Add(path.ToString());
            }

            for (char c = (char)0; c < R; c++)
            {
                path.Append(c);
                Traverse(node.children[c], path, res);
                path.Remove(path.Length - 1, 1);
            }
        }

        private TrieNode<V> GetNode(TrieNode<V> node, string key)
        {
            TrieNode<V> p = node;

            for (int i = 0; i < key.Length; i++)
            {
                if (p == null)
                {
                    return null;
                }

                char c = key[i];
                p = p.children[c];
            }

            return p;
        }

    }

}