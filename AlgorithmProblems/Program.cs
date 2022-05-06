using AlgorithmProblems;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                                   WELCOME TO ALGORITHM PROGRAMS                                   ");
        bool check = true;
        const string path = @"D:\Practice Problems\AlgorithmProblems\AlgorithmProblems\AlgorithmProblems\Data.txt";
        Console.WriteLine("1.Binary Search\n2.Exit");
        while (check)
        {
            Console.Write("\nEnter an option to execute :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binary = new BinarySearch();
                    string[] inputArray = File.ReadAllLines(path);
                    Console.WriteLine("Enter a word to search :");
                    string word = Console.ReadLine();
                    binary.Binary(inputArray, word);
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}
