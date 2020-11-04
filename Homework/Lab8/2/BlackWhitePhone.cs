using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8._2
{
    public class BlackWhitePhone : ButtonPhone
    {
        public string Resolution { get; set; }
        public string Color { get; set; }
        public string SizeScreen { get; set; }
        public BlackWhitePhone()
        {
            AvailableNumbers.AddRange(new List<string>
            {
                "Reset"
            });
        }
    }
}
