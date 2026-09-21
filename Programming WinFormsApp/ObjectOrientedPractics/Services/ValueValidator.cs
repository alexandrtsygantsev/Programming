using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propetyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propetyName} должен быть меньше {maxLength}");
            }
        }
        public static void AssertStringOnWords(string value, string propertyName)
        {

            string pattern = @"^\s*[А-ЯЁA-Z][а-яёa-z\-]+\s+[А-ЯЁA-Z][а-яёa-z\-]+\s+[А-ЯЁA-Z][а-яёa-z\-]+\s*$";

            if (value == null || !Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException(
                    $"{propertyName} должен содержать фамилию, имя и отчество");
            }
        }
    }
}
