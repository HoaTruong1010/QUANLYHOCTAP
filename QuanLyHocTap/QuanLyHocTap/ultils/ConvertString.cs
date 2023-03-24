using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyHocTap.ultils
{
    public class ConvertString
    {
        public string DeleteSpacing (string text)
        {
            Regex trimmer = new Regex(@"\s\s+");

            text = text.Trim();
            return trimmer.Replace(text, " ");
        }

        public string DeleteSpacingID(string text)
        {
            return text.Replace(" ", "");
        }
    }
}
