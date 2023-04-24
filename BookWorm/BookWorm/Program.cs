namespace BookWorm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of words:");
            int numOfWords = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter the words:");
            string[] Words = new string[numOfWords];

            for (int i = 0; i < numOfWords; i++)
            {
                Words[i] = Console.ReadLine();

            }
         
            string Shortest = Words[0];
            for (int i = 1; i < numOfWords; i++)
            {
                if (Words[i].Length < Shortest.Length)
                {
                    Shortest = Words[i];
                }
            }
            Console.WriteLine("The shortest word is : " + Shortest);

            //Presentt in the list or not

            Console.WriteLine("Enter the number of words and name");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] city = new string[n];
            for (int i = 0; i < city.Length; i++)
            {
                city[i] = Console.ReadLine();
            }
            bool find1 = false;
            string find = Console.ReadLine();
            for (int i = 0; i < city.Length; i++)
            {
                if (city[i] == find)
                {
                    find1 = true;
                    break;
                }
            }
            if (find1 == true)
            {
                Console.WriteLine($"The word is present in the list is {find}");
            }
            else
            {
                Console.WriteLine($"The word is not present in the list is {find}");
            }



            //Sorting in alphabetical order

            Array.Sort(Words);
            Console.WriteLine(" The Sorted Array is:");
            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }

            // palindrome

            Console.WriteLine("Enter the number of words: ");
            int k= Convert.ToInt32(Console.ReadLine());

            string[] words = new string[n];
            Console.WriteLine("Enter the words: ");
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            int count = 0;
            string pwords = " ";
            for (int i = 0; i < n; i++)
            {
                string rwords = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    rwords += words[i][j];
                }
                if (words[i] == rwords)
                {
                    count++;
                    pwords += words[i] + " ";
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"The number of palindromes in the list: {count}");
                Console.WriteLine($"Palindromic words: {pwords}");
            }
            else
            {
                Console.WriteLine("There are no palindromes in the list");
            }
        }


    }
    
}