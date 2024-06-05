namespace Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Enter a word: ");
                string inputString = Console.ReadLine();

                if (IsPalindrome(inputString))
                {
                    Console.WriteLine($"{inputString} is a Palindrome.");
                }
                else
                {
                    Console.WriteLine($"{inputString} is not a palindrome");
                }
            }
            while (true);

        }

        static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;

            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}
