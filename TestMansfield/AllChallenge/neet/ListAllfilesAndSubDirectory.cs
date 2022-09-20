using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class ListAllfilesAndSubDirectory
    {
        public void PrintAllFiles(string path)
        {
            PrintAllFiles(path, 1);
        }

        public void PrintAllFiles(string path, int level)
        {
            if (!Directory.Exists(path) && !File.Exists(path)) return;

            var indentFolder = new string('\t', level -1 );
            var indent = new string('\t', level);
            if (Directory.Exists(path))
            {
                Console.WriteLine($"{indentFolder} [{path}]");
            }else
            {
                Console.WriteLine($"{indentFolder} {path}");
            }

            var files = Directory.EnumerateFiles(path);
            foreach (var f in files) { Console.WriteLine($"{indent} {f}"); }

            var dirs = Directory.EnumerateDirectories(path);
            foreach(var d in dirs)
            {                
                PrintAllFiles(d, level+1);
            }
        }
    }
}
