// create a cs file to find the next permutation of a given array
// next permutation is the next lexicographic permutation of the ordered set of numbers.
// the array is ordered in ascending order.

public class NextPermutation
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };
        NextPermutation(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    public static void NextPermutation(int[] nums)
    {
        int i = nums.Length - 2;
        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }
        if (i >= 0)
        {
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }
        Reverse(nums, i + 1);
    }

    public static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public static void Reverse(int[] nums, int start)
    {
        int i = start, j = nums.Length - 1;
        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }
}