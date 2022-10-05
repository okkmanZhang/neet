using System.Collections.Generic;
using System.Linq;

public class _118PascalTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows == 0) return new List<IList<int>>();
        if (numRows == 1) {            
            IList<IList<int>> r = new List<IList<int>>();
            r.Add(new List<int>() { 1 });
            return r;
        }
        if (numRows == 2) {
            IList<IList<int>> r = new List<IList<int>>();
            r.Add(new List<int>() { 1 });
            r.Add(new List<int>() { 1, 1 });
            return r;
        }

        var preTri = Generate(numRows -1);
        var preRow = preTri[preTri.Count()-1];
        int i = 0;
        List<int> newList = new List<int>();
        newList.Add(1);

        while ( i < preRow.Count()-1){
            newList.Add(preRow[i]+preRow[i+1]);
            i++;
        }
        newList.Add(1);

        preTri.Add(newList);
        return  preTri;
    }

    
}