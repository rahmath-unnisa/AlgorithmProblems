using AlgorithmProblems;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Algorithm Programs");
        bool end = true;
        Console.WriteLine("1.BinarySearch\n2.End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BasicAlgorithms basic = new BasicAlgorithms();
                    basic.Binary();
                    break;
                case 2:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}