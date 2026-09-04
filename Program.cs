namespace SearchTools;


public class Program
{
    public static void Main(string[] args)
    {
        // Binary search requires a sorted list
        List<int> numbers = [ 3, 7, 12, 18, 25, 31, 42, 56, 63, 78, 91];

        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());

        SearchUtility searchUtility = new SearchUtility();
        int index = searchUtility.BinarySearch(numbers, target);

        if (index == -1)
        {
            Console.WriteLine($"{target} was not found.");
        }
        else
        {
            Console.WriteLine($"{target} was found at index {index}.");
        }
    }
}
