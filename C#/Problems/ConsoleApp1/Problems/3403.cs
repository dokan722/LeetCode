using System.Linq;

namespace Problems.Problems
{
    public class _3403 : IProblem
    {
        public string AnswerString(string word, int numFriends)
        {
            var maxSign = word.Max(c => c);
            if (numFriends == 1)
                return word;
            var subs = new List<string>();
            for (int i = 0; i < word.Length; ++i)
            {
                if (word[i] == maxSign)
                    subs.Add(word.Substring(i));
            }
            var maxSub = subs.Max(x => x);

            return maxSub.Substring(0, int.Min(word.Length - numFriends + 1, maxSub.Length));
        }

        public string AnswerString2(string word, int numFriends)
        {
            var numLetters = word.Length;

            var words = new HashSet<string>();
            GetWordsRec(word, words, numFriends);
            Console.WriteLine(string.Join(", ", words));

            return words.MaxBy(x => x);
        }

        public bool Test()
        {
            var word = "aann";

            var numFriends = 2;

            var result = AnswerString(word, numFriends);

            var expectedResult = "nnn";

            Console.WriteLine("Result: " + result);

            return result == expectedResult;
        }

        private void GetWordsRec(string word, HashSet<string> words, int numFriends)
        {
            if (numFriends == 1)
            {
                words.Add(word);
                return;
            }    

            
            var spareLetters = word.Length - numFriends + 1;
            for (int i = 1; i <= spareLetters; ++i)
            {
                words.Add(word.Substring(0, i));
                GetWordsRec(word.Substring(i), words, numFriends - 1);
            }
        }
    }
}
