namespace ClassLibrary1
{
    public class _752OpenTheLock
    {
        public int OpenLock(string[] deadends, string target)
        {

            string start = "0000";
            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            foreach (var iStr in deadends)
            {
                visited.Add(iStr);
            }

            int res = 0;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    string current = queue.Dequeue();

                    if (current == target)
                    {
                        return res;
                    }

                    if (visited.Contains(current))
                    {
                        continue;
                    }
                    else
                    {
                        visited.Add(current);
                    }

                    for (int h = 0; h < target.Length; h++)
                    {
                        queue.Enqueue(TurnUp(current,h));
                        queue.Enqueue(TurnDown(current,h));
                    }
                }

                res++;
            }

            return -1;



            string TurnUp(string key, int j)
            {
                char[] chars = key.ToArray<char>();
                if (chars[j] == '9')
                {
                    chars[j] = '0';
                }
                else
                {
                    chars[j]++;
                }
                return string.Join("",chars);
            }
            string TurnDown(string key, int j)
            {
                char[] chars = key.ToArray<char>();
                if (chars[j] == '0')
                {
                    chars[j] = '9';
                }
                else
                {
                    chars[j]--;
                }
                return string.Join("",chars);
            }

        }

    }
}