using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge
{
    public class _937ReorderDatainLogFilesClass1
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var newLogs = logs.ToList();

            var digitList = newLogs.Where(w => Isdigit(w.Split(' ')[1]));
            var letterList = newLogs.Where(w => !Isdigit(w.Split(' ')[1])).ToList();

            int stringListCompare(string[] a, string[] b)
            {
                int i = 0;
                while( i < a.Length && i < b.Length)
                {
                    if (a[i].CompareTo(b[i]) != 0)
                    {
                        return a[i].CompareTo(b[i]);
                    }

                    i++;
                }


                if (a.Length == b.Length) return 0;

                if (a.Length < b.Length) return -1;

                if (a.Length > b.Length) return 1;


                return 0;
            }

            bool Isdigit(string s)
            {
                return !s.Any(a => a < '0' || a > '9');
            }

            letterList.Sort((a, b) =>
                 {
                     if (!Isdigit(a.Split(' ')[1]) && Isdigit(b.Split(' ')[1]))
                     {
                         return -1;
                     }

                     if (Isdigit(a.Split(' ')[1]) && !Isdigit(b.Split(' ')[1]))
                     {
                         return 1;
                     }

                     if (Isdigit(a.Split(' ')[1]) && Isdigit(b.Split(' ')[1]))
                     {
                         return 0;
                     }

                     if (!Isdigit(a.Split(' ')[1])
                         && !Isdigit(b.Split(' ')[1]))
                     {

                         var x = stringListCompare(a.Split(' ').Skip(1).ToArray(), b.Split(' ').Skip(1).ToArray());
                        return x != 0 ? x : a.Split(' ')[0].CompareTo(b.Split(' ')[0]);

                     }
                     else
                         return 0;                    

                 });

            letterList.AddRange(digitList);
            return letterList.ToArray();
                
        }
    }
}
