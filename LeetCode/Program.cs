using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }
        public bool isPolindrom(string s)
        {
            int i = 0;
            while (s.Length / 2 > i)
            {
                if (s[i] != s[s.Length - (i + 1)])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        public int SingleNumber(int[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                c = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    return array[i];
                }
            }
            return 0;
        }
        public int CountSymmetric(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)
            {
                int sum1 = 0, sum2 = 0, n = 0, o = 1, c = 0;
                while (i >= o)
                {
                    c++;
                    o *= 10;
                }
                o = 1;
                if (c % 2 == 0)
                {
                    while (i >= o)
                    {
                        if (n < c / 2)
                        {
                            sum1 += (i / o) % 10;
                            o *= 10;
                            n++;
                        }
                        else
                        {
                            sum2 += (i / o) % 10;
                            o *= 10;
                            n++;
                        }

                    }

                }
                if (sum1 != 0 && sum2 != 0 && sum1 == sum2)
                {
                    count++;
                }
            }
            return count;
        }
        public int MinExtraChar(string s, string[] dictionary)
        {
            foreach (string item in dictionary)
            {
                if (s.Contains(item))
                {
                    s = s.Remove(s.IndexOf(item), item.Length);
                }
            }
            return s.Length;
        }
        public int MinimizedStringLength(string s)
        {
            string r = "";
            for (int i = 0; i < s.Length; i++)
            {
                bool b = false;
                for (int j = 0; j < r.Length; j++)
                {
                    if (s[i] == r[j])
                    {
                        b = true;
                    }
                }
                if (b == false)
                {
                    r += s[i];
                }
            }
            return r.Length;
        }
        public List<List<int>> PascalTriangle(int n)
        {
            List<List<int>> list = new List<List<int>>();
            List<int> list1 = new List<int>() { 1 };
            List<int> list2 = new List<int>() { 1, 1 };
            list.Add(list1);
            list.Add(list2);
            for (int i = 0; i < 5; i++)
            {
                List<int> l = list[i + 1];
                List<int> newl = new List<int>();
                newl.Add(1);
                int j = 0;
                bool b = true;
                while (b)
                {
                    newl.Add(l[j] + l[j + 1]);
                    if (l[j + 1] == 1)
                    {
                        b = false;
                    }
                    j++;
                }
                newl.Add(1);

                list.Add(newl);
            }
            return list;
        }
        public int[] CountBits(int n)
        {
            int[] r = { };

            for (int i = 0; i <= n; i++)
            {
                string b = "", result = "";
                int m = i;
                int c = 0;
                if (m == 0)
                {
                    b = m.ToString();
                }
                while (m > 0)
                {
                    b = b + (m % 2).ToString();
                    m /= 2;
                }
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    result += b[j];
                }
                foreach (var item in result)
                {
                    if (item.ToString() == "1")
                    {
                        c++;
                    }
                }
                r = r.Append(c).ToArray();
            }
            return r;
        }
        public int ReverseInteger(int x)
        {
            var result = 0;
            int max = Convert.ToInt32(Math.Pow(2, 31) - 1);
            int min = Convert.ToInt32(Math.Pow(-2, 31));
            while (x != 0)
            {
                result = result * 10 + x % 10;
                x = x / 10;
            }
            if (result >= max || result <= min)
            {
                return 0;
            }
            return Convert.ToInt32(result);
        }
    }
}