using System.Text;

namespace PointsBet.StringClassLibrary
{
    public class StringFormatter
    {
        /// <summary>
        /// Function to create a comma separated list from an array of string        
        /// </summary>
        /// <param name="items">array of string</param>
        /// <param name="quote">delimiter</param>
        /// <returns></returns>
        public static string ToCommaSeparatedList(string[] items, string quote)
        {                                    
            return items == null ?
                string.Empty :
                string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }       
    }
}
