using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at
{
    /*     
    Given a list of files with multiple tags associated with them, 
    group the files based on tags and return a list of top tags based on total file size.
    
    [input]
    files: file1, file2, file3
    tags:  [cat, dog, ant], [dog, frog], [dog, cat]
    fileSizes: 1, 2, 3

    [output]
    dog, cat, frog, ant

    explanation:
    cat: file1,1 file3, 3   1+3 = 4
    dog: file1,1 file2, 2 file3, 1+2+3  = 6
    frog: file2,2 = 2
    ant: file,1 = 1    
     */
    public class FileTags
    {
        public IList<string> GroupFileTag(string[] fileNames, List<string[]> tags, int[] sizes)
        {
            var length = sizes.Length;

            //hashmap<fileName, size>
            Dictionary<string, int> fileSizes = new Dictionary<string, int>();
            for (int i = 0; i < length; i++)
            {
                fileSizes[fileNames[i]] = sizes[i];
            }

            //hashmap<tag, size>
            Dictionary<string, int> tagSizes = new Dictionary<string, int>();
            for (int i = 0; i < length; i++)
            {
                foreach (var tag in tags[i])
                {
                    if (!tagSizes.ContainsKey(tag))
                    {
                        tagSizes[tag] = 0;
                    }

                    tagSizes[tag] += fileSizes[fileNames[i]];
                }
            }

            //sort tags
            var sortedTag = tagSizes.Keys.ToList();
            sortedTag.Sort((a, b) => tagSizes[b] != tagSizes[a] 
                ? tagSizes[b] - tagSizes[a] 
                : tagSizes[a].CompareTo(tagSizes[b]));

            return sortedTag;
        }
        /*
          The question was initially about a list of files where each file had a collection name and size associated with it. 
          I was required to calculate the total size of all the files and the total size of each collection. 
          The question was then scaled up where I had to find the top n largest collection sizes 
            and then scaled again to each file having multiple collection names.
         */
    }
}
