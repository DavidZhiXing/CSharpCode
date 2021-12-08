// create an unit test for the NextPermutation function in next_permutation.cs

public class NextPermutationTest
{
    [Fact]
    public void Test1()
    {
        int[] nums = new int[] { 1, 2, 3 };
        int[] expected = new int[] { 1, 3, 2 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = new int[] { 3, 2, 1 };
        int[] expected = new int[] { 1, 2, 3 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test3()
    {
        int[] nums = new int[] { 1, 1, 5 };
        int[] expected = new int[] { 1, 5, 1 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test4()
    {
        int[] nums = new int[] { 3, 2, 1, 0 };
        int[] expected = new int[] { 0, 1, 2, 3 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test5()
    {
        int[] nums = new int[] { 1, 2, 3 };
        int[] expected = new int[] { 1, 3, 2 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test6()
    {
        int[] nums = new int[] { 1, 1, 5 };
        int[] expected = new int[] { 1, 5, 1 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test7()
    {
        int[] nums = new int[] { 3, 2, 1, 0 };
        int[] expected = new int[] { 0, 1, 2, 3 };
        NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }

}