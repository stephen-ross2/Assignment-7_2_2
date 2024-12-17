namespace Assignment_7_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();

            string result = ReverseVowels(s);
            Console.WriteLine("Output: " + result);
        }

        static string ReverseVowels(string s)
        {
            // Convert string to character array for manipulation
            char[] arr = s.ToCharArray();

            // Define vowels
            string vowels = "aeiouAEIOU";

            // Two pointers
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                // Move 'left' until a vowel is found
                while (left < right && !vowels.Contains(arr[left]))
                {
                    left++;
                }

                // Move 'right' until a vowel is found
                while (left < right && !vowels.Contains(arr[right]))
                {
                    right--;
                }

                // Swap vowels
                if (left < right)
                {
                    char temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }

            // Return the modified string
            return new string(arr);
        }
    }
}
}
