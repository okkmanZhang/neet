namespace ClassLibrary1
{
    public class _797AllPathFromSourceToTarget
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            List<int> path = new List<int>();
            Traverse(graph,0,path);
            return res;
        }
        private void Traverse(int[][] graph, int s, List<int> path)
        {
            path.Add(s);
            int n = graph.Length;
            if(s == n-1)
            {
                res.Add(new List<int>(path));
            }

            foreach (var item in graph[s])
            {
                Traverse(graph,item, path);
            }

            path.RemoveAt(path.Count-1);
        }
    }
}