using System.Text;

namespace PointsBet.StringClassLibrary
{
    public class StringFormatter
    {
        /// <summary>
        /// 1. Function to create a comma separated list from an array of string
        /// 2. This function uses string.Join, as the JOIN operation performance is at par with StringBuilder even for large string arrays (as per the test case in MSTest project).
        /// 3. String.JOIN is highly optimized in .NET8. It also reduces lines of code and simplifies the code.        
        /// </summary>
        /// <param name="items">array of string</param>
        /// <param name="quote">delimiter</param>
        /// <returns></returns>
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            // 1. If null array then return empty string
            // 2. Join string using string.Join, use LINQ to select items from the array.
            // 3. Use string interpolation to format each string.
            return items == null ?
                string.Empty :
                string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }

        /// <summary>
        /// Alternate Implementation using String Builder to create a comma separated list from an array of string
        /// </summary>
        /// <param name="items">array of string</param>
        /// <param name="quote">delimiter</param>
        /// <returns></returns>
        public static string ToCommaSeparatedListWithStringBuilder(string[] items, string quote)
        {
            // 1. If null array then return empty string            
            if (items == null)
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            // 2. Join string using stringbuilder            
            foreach (string item in items)
            {
                sb.Append(quote).Append(item).Append(quote).Append(", ");
            }

            // 3. Remove the last comma and space
            if (sb.Length > 2)
                sb.Length -= 2;

            return sb.ToString();
        }
    }
}
