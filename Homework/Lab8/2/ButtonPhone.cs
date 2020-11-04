using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8._2
{
    public class ButtonPhone : BasePhone
    {
        public ButtonPhone()
        {
            AvailableNumbers.AddRange(new List<string>
            {
                "Enter",
                "Cancel",
                "*",
                "#"
            });
        }
    }
}
