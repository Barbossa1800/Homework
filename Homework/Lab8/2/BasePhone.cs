using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8._2
{
    public class BasePhone
    {
        public int Number { get; set; }
        public List<string> AvailableNumbers = new List<string>
        {
           "0","1","2","3","4","5","6","7,","8","9"
        };
    }
}
