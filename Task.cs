using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TeodorovLabs
{
    public class Task1
    {
        static public List<object> GetIntegerFromList(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetType() != typeof(int))
                {
                    list.Remove(list[i]);
                    i = i - 1;
                }

            }

            return list;
        }
    }
    public class Task2
    {
        static public char First_non_repeating_letter(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                char a = str[i];
                bool flag = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (((a == str[j]) & (i != j)) || ((a == Char.ToUpper(str[j])) & (i != j)) || ((a == Char.ToLower(str[j])) & (i != j)))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    return a;
                }
            }

            return ' ';
        }
    }
    public class Task3
    {
        static public int Digital_Root(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int a = num % 10;
                sum += a;
                num = num / 10;
            }
            if (sum / 10 != 0)
            {
                sum = Digital_Root(sum);
            }

            return sum;
        }
    }
    public class Task4
    {

        static public int Number_of_pairs(int[] arr, int target)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }

    }
    public class Task5
    {

        static public string Meeting_Names(string s)
        {
            if (s == "")
                return "";

            s = s.ToUpper();
            string[] subs = s.Split(';');

            List<int> arr = new List<int>() { 1, 2, 3 };
            Dictionary<string, List<string>> surnames = new Dictionary<string, List<string>>();

            for (int i = 0; i < subs.Length; i++)
            {
                string[] subs1 = subs[i].Split(':');
                if (surnames.ContainsKey(subs1[1]) == false)
                {
                    surnames[subs1[1]] = new List<string> { subs1[0] };
                }
                else
                {
                    surnames[subs1[1]].Add(subs1[0]);
                }
            }

            foreach (string i in surnames.Keys.ToList())
            {
                List<string> mas = surnames[i];
                mas.Sort();
                surnames[i] = mas;
            }

            var SortDict = new SortedDictionary<string, List<string>>(surnames);

            string result = null;

            foreach (string key in SortDict.Keys)
            {
                for (int i = 0; i < SortDict[key].Count; i++)
                    result += "(" + key + ", " + SortDict[key][i] + ")";
            }

            return result;
        }
    }
}