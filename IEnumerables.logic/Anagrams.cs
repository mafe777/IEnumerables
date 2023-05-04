namespace IEnumerables.logic
{
    public class Anagrams
    {
        public int Word1 { get; }
        public int Word2 { get; }
        public void IsAnagram ( string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                Console.WriteLine("These words are not anagrams.");
                return;
            }
            char[] word1Array = word1.ToCharArray();
            char[] word2Array = word2.ToCharArray();
            Array.Sort(word1Array);
            Array.Sort(word2Array);
            bool areAnagrams = true;
            for (int i = 0; i < word1Array.Length; i++)
            {
                if (word1Array[i] != word2Array[i])
                {
                    areAnagrams = false;
                    break;
                }
            }
            if (areAnagrams)
            {
                Console.WriteLine("These words are anagrams!");
            }
            else
            {
                Console.WriteLine("These words are not anagrams.");
            }
        }

    }
}