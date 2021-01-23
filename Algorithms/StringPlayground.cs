namespace Algorithms
{
    public static class StringPlayground
    {
        // Reverse String
        public static string ReserveString(string inStr)
        {
            var result = new char[inStr.Length];
            var index = inStr.Length - 1;

            foreach(char ch in inStr)
            {
                result[index--] = ch;
            }
            return new string(result);
        }

        public static string ReserveStringLoop(string inStr)
        {
            char[] arrTmp = inStr.ToCharArray();

            for (int i = 0 ,  j = arrTmp.Length -1; i < j; i++, j--)
            {
                arrTmp[i] = inStr[j];
                arrTmp[j] = inStr[i];
            }
            return new string(arrTmp);
        }

        // find out pattern from string

        // IsPali?

    }
}
