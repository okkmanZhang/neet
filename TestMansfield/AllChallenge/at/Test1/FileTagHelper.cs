using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1
{

 /*     
    Given a list of files with multiple tags associated with them, 
    group the files based on tags 
    and return a list of top tags based on total file size.

    file1: cat, dog
    file2: dog, frog
    file3: dog, cat    

    file1: 1
    file2: 2
    file3: 3

    cat: file1, file3 (1+3=4)
    dog: file1, file3 (1+3=4)
    frog: file2  (2)  

    result:
    cat dog frog

 */

    public class FileTagHelper
    {
        public string[] TopTags((string fileName, string[] tags)[] fileTags, int[] fileSizes)
        {
            //group files by tag
            //<tag, size>
            var tagFileMap = new Dictionary<string, int>();

            //<fileName, size>
            var fileSizeMap = new Dictionary<string, int>();

            for(int i=0; i < fileSizes.Length; i++)
            {
                fileSizeMap[fileTags[i].fileName] = fileSizes[i];
            }

            foreach(var fileTag in fileTags)
            {
                foreach(var tag in fileTag.tags)
                {
                    if (tagFileMap.ContainsKey(tag))
                    {
                        tagFileMap[tag] += fileSizeMap[fileTag.fileName];
                    }else
                    {
                        tagFileMap[tag] = fileSizeMap[fileTag.fileName];
                    }
                }
            }

            var sortedTag = tagFileMap.Keys.ToList();

            sortedTag.Sort((a, b) => tagFileMap[b] - tagFileMap[a]  );

            return sortedTag.ToArray();
        }        
    }    
}
