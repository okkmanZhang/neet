using System.Text;

namespace ClassLibrary1
{
    public class _316RemoveDuplicateLetters
    {
        public string RemoveDuplicateLetters(string s)
        {
            Stack<char> stk = new Stack<char>();
            int[] count = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;                
            }

            Boolean[] inStack = new bool[256];
            foreach (var item in s)
            {
                count[item]--;

                if(inStack[item]) continue;

                while(stk.Count >0 && stk.Peek() >item)
                {
                    if(count[stk.Peek()]==0) break;

                    inStack[stk.Pop()] = false;
                }
                stk.Push(item);
                inStack[item] = true;
            }

            StringBuilder sb = new StringBuilder();
            while(stk.Count>0)
            {
                sb.Append(stk.Pop());
            }

            return new string(sb.ToString().ToArray().Reverse().ToArray()) ;
        }
    }
}