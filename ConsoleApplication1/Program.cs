using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = new int[] { 12, 315, 583, 12389, 34722641, 9876 };
            string[] expected = new string[] { "21", "351", "835", "12398", "34724126", "9876" };
            for (int i = 0; i < tests.Length; i++) {
                var result = NextPermutation(tests[i]);
                Console.WriteLine(result);
                if (String.Equals(result, expected[i])) {
                    Console.WriteLine("Correct!");
                }
            }
        }

        private static string NextPermutation(int test)
        {
            var original = test.ToString();

            // Find rightmost character that is smaller than its next one
            for (int i = original.Length - 2; i >= 0; i--) {
                if (original[i] < original[i + 1]) {
                    return TrySwapping(original, i);
                }
            }

            // No dice
            return original;
        }

        private static string TrySwapping(string original, int position)
        {
            List<char> list = new List<char>();
            list.AddRange(original.Substring(position));

            // Which character are we swapping?
            var charToSwap = original[position];

            // Find the next highest character in the remaining list
            var nextHighestCharacter = (from c in list where c > charToSwap orderby c select c).FirstOrDefault();

            // Start the result
            StringBuilder result = new StringBuilder();
            result.Append(original.Substring(0, position));
            result.Append(nextHighestCharacter);

            // Okay, let's make sure we don't use it twice
            list.Remove(nextHighestCharacter);

            // Start appending values in order
            list.OrderBy(c => c);
            foreach (var c in list.OrderBy(c => c)) {
                result.Append(c);
            }
            return result.ToString();
        }
    }
}
