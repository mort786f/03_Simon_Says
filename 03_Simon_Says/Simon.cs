using System;

namespace _03_Simon_Says
{
    public class Simon
    {
        public string Echo(string v)
        {
            return v.ToLower();
        }

        public string Shout(string v)
        {
            return v.ToUpper();
        }

        public string Repeat(string v)
        {
            return v + " " + v;
        }

        public object Repeat(string v1, int v2)
        {
            string All = "";
            for (int i = 0; i < v2; i++)
            {
                All = All + v1 + " ";
            }
            return All.Trim();

        }
    }
}