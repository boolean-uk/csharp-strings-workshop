using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_strings_workshop.Main
{
    /// <summary>
    /// Class to describe the different ways of joing two strings together!
    /// </summary>
    public class StringSamples
    {
        public string StringInterpolationExample()
        {
            string firstName = "Albert";
            string lastName = "Einstein";
            string fullName = $"{firstName} {lastName}";
            return fullName;
        }
        public string StringBuilderExample()
        {
            string firstName = "Albert";
            string lastName = "Einstein";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(firstName);
            stringBuilder.Append(" ");
            stringBuilder.Append(lastName);
            string fullName = stringBuilder.ToString();
            return fullName;
        }
        public string JoinExample()
        {
            string[] names = { "Albert", "Einstein" };
            string fullName = string.Join(" ", names);
            return fullName;
        }
        public string ConcatExample()
        {
            string firstName = "Albert";
            string lastName = "Einstein";
            string fullName = string.Concat(firstName, " ", lastName);
            return fullName;
        }
        public string PlusOperatorExample()
        {
            string firstName = "Albert";
            string lastName = "Einstein";
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        public string FormatExample()
        {
            string firstName = "Albert";
            string lastName = "Einstein";
            string fullName = string.Format("{0} {1}", firstName, lastName);
            return fullName;
        }
                             
    }
}
