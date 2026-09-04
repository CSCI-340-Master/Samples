namespace 
public class SearchUtility
{
    public int BinarySearch(List<int> values, int target)
    {
        return BinarySearch(values, target, 0, values.Count - 1);
    }

    private int BinarySearch(List<int> values, int target, int low, int high)
    {
        // Base case: search range is empty
        if (low > high)
        {
            return -1;
        }

        int middle = (low + high) / 2;

        if (values[middle] == target)
        {
            return middle;
        }

        if (target < values[middle])
        {
            // Search the left half
            return BinarySearch(values, target, low, middle - 1);
        }
        else
        {
            // Search the right half
            return BinarySearch(values, target, middle + 1, high);
        }
    }
}
