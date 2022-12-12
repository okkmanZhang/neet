using System.Text;

namespace ClassLibrary1
{
    public class _773SlidingPuzzle
    {
        public int SlidingPuzzle(int[][] board) {
        
            int m =2, n =3;
            StringBuilder sb = new StringBuilder();
            string target = "123450";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(board[i][j]);
                }
            }

            string start = sb.ToString();
            int[][] neighbor = new int[][]{
                new int[] {1,3},
                new int[] {0,4,2},
                new int[] {1,5},
                new int[] {0,4},
                new int[] {3,1,5},
                new int[] {4,2},
            };

            Queue<string> q = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            q.Enqueue(start);
            visited.Add(start);

            int step =0;
            while(q.Count>0)
            {
                int sz = q.Count;
                for (int i = 0; i < sz; i++)
                {
                    string cur = q.Dequeue();
                    if(target==cur) return step;

                    int idx = 0;
                    for(;cur[idx]!='0';idx++);
                    foreach (var item in neighbor[idx])
                    {
                        string new_b = Swap(cur.ToCharArray(),item,idx);
                        if(!visited.Contains(new_b))
                        {
                            q.Enqueue(new_b);
                            visited.Add(new_b);
                        }
                    }                    
                }
                step++;
            }

            return -1;

            string Swap(char[] chars,int i,int j)
            {
                char temp = chars[i];
                chars[i]=chars[j];
                chars[j]=temp;
                return new String(chars);
            }
        }
        
    }
}