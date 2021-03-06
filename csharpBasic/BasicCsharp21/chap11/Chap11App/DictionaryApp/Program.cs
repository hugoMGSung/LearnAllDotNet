using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        // 실무에서 많이 쓰는 컬렉션 2
        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>() {
                { 1, "One" },  { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" }, };
            /*pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";*/

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "One";
            pairs2["이"] = "Two";
            pairs2["삼"] = "three";
            pairs2["4"] = "Four";
            pairs2["오"] = "Five";

            foreach (var item in pairs2)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
