using System.Collections;

public class _1366RankTeamsByVotes {
    public string RankTeams(string[] votes) {

        if (votes.Length == 1) return votes[0];
        int numberOfposition = votes[0].Length;

        Dictionary<char, int[]> x = new Dictionary<char, int[]>();
        foreach(char c in votes[0])
        {            
            x.Add(c, new int[numberOfposition]);
        }

        for (int i = 0; i < votes.Length; i++)
        {        
            for (int j = 0; j < votes[i].Length; j++)
            {
                ((int[])x[votes[i][j]])[j]++;
            }            
        }

        foreach(var k in x.Keys) {
             Console.Write(k);
             Console.WriteLine(string.Join(",", (int[])x[k]));
        }

        var ll = x.Keys.ToList();
        ll.Sort((a,b) => {
            int[] listA = x[a];
            int[] listB = x[b];

            for (int i = 0; i < numberOfposition; i++)
            {
                if (listA[i] > listB[i]) return -1;
                if (listA[i] < listB[i]) return 1;
            }
            
            return a > b? 1: -1;
        });

        return string.Join("",ll);
    }
}