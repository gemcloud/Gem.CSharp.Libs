using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class FrozenFindPatternCount
    {
        public static Dictionary<string, int> findPatternBylen_Linq(string inpuStr, int patternLen)
        {
            Dictionary<string, int> patternResult = null;

            if (patternLen <= 1 || patternLen >= inpuStr.Length)
                return patternResult;

            // 1. split string by patternLen.
            List<string> lstSubString = new List<string>();

            for (int i = 0; i < inpuStr.Length - 1; i++)
            {
                if (i > inpuStr.Length - patternLen)
                    break;
                string tmpitem = inpuStr.Substring(i, patternLen);
                lstSubString.Add(tmpitem);
            }

            // 2. search same of items and count > 1
            // Linq way
            patternResult = lstSubString.GroupBy(x => x)
                                    .Where(g => g.Count() > 1)
                                    .ToDictionary(x => x.Key, x => x.Count());
            return patternResult;
        }

        public static IEnumerable<KeyValuePair<string, int>> findPatternBylen_Loop(string inpuStr, int patternLen)
        {
            if (patternLen <= 1 || patternLen >= inpuStr.Length)
                return null;

            // 1. split string by patternLen.
            List<string> lstSubString = new List<string>();

            for (int i = 0; i < inpuStr.Length - 1; i++)
            {
                if (i > inpuStr.Length - patternLen)
                    break;
                string tmpitem = inpuStr.Substring(i, patternLen);
                lstSubString.Add(tmpitem);
            }

            var loopResults = FindDuplicates(lstSubString);
            return loopResults;
        }


        private static IEnumerable<KeyValuePair<string, int>> FindDuplicates(List<string> inputdata)
        {
            Dictionary<string, int> stringSet = new Dictionary<string, int>();
            foreach (var item in inputdata)
            {
                int count = 0;
                if (stringSet.TryGetValue(item, out count))
                {
                    stringSet[item] = count + 1;
                }
                else
                {
                    stringSet[item] = 1;
                }
            }
            return stringSet.Where(p => p.Value > 1);
        }
    }
}
