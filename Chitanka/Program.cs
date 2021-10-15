using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chitanka
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\e\Cats.txt";
            string text = File.ReadAllText(path);
            var words = new List<string>(text.Split('.', '?', '!', ' ', ';', ':', ','));
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "")
                {
                    words.RemoveAt(i);
                }
            }
            //word count
            Console.WriteLine(words.Count);
            //shortest & longest word
            if (words.Count > 0)
            {
                var shortestWord = words[0];
                for (int i = 0; i < words.Count; i++)
                {
                    string word = words[i];
                    if (word.Length < shortestWord.Length)
                    {
                        shortestWord = word;
                    }
                }
                var longestWord = words[0];
                for (int j = 0; j < words.Count; j++)
                {
                    string word = words[j];
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine("Shortest Word: {0}", shortestWord);
                Console.WriteLine("Longest Word: {0}", longestWord);
            }
            //average word length
            double averageLength = words.Average(w => w.Length);
            Console.WriteLine("Average word length is {0}.", averageLength);
            //5 most common words
            foreach (string word in words.Take(5))
            {
                    Console.WriteLine(word + "  " + word.Count());
            }

            //5 least common words
            Console.ReadLine();
        }
    }
}
