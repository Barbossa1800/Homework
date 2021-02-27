using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public class Lists
    {
        private List<string> values;
        public Lists()
        {
            values = new List<string>();
        }
        public Lists(List<string> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentNullException(); // исключение 
            values = list;
        }

        public List<string> Values => values; // паблик свойство 
        public void AddValue(string value)
        {
            values.Add(value);
        }
        public int GetIndexByValue(string value)
        {
            return values.IndexOf(value);
        }
        public string[] GetListAsArray()
        {
            return values.ToArray();
        }
    }
}
