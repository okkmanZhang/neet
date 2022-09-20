using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class FileSample
    {
        
        public int Size { get; set; }
        public string Tag { get; set; }
    }

    public class ListFileTagsSize
    {
        public string[] SortFileByTagAndSize(FileSample[] files)
        {
            var tags = new Dictionary<string, int>();
            foreach (var f in files)
            {
                if (!tags.ContainsKey(f.Tag))
                {
                    tags.Add(f.Tag, f.Size);
                }
                else
                {
                    tags[f.Tag] += f.Size;
                }
            }

            var tagList = tags.Keys.ToList();
            tagList.Sort((a, b) => tags[a] - tags[b]);
            return tagList.ToArray();
        }
    }
}
