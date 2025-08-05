namespace Assignment5._2._4
{
    internal class Program
    {
        static void Palindrome_Recursion(string str, int start, int end)
        {
            bool isPalindrome = true;
            bool notPalindrome = false;

            if (start >= end)
            {
                Console.WriteLine($"{isPalindrome}");
                return;
            }
            if (str[start] != str[end])
            {
                Console.WriteLine($"{notPalindrome}");
                return;
            }
            Palindrome_Recursion(str, start + 1, end - 1);
        }
        static void Palindrome(string str)
        {
            str = str.ToLower().Replace(" ", "");
            Palindrome_Recursion(str, 0, str.Length - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome:");
            string input = Console.ReadLine();
            Palindrome(input);
        }
    }
}
