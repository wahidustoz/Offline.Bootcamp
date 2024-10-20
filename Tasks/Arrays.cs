namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int FindMissingNumber(int[] nums)
    {
        throw new NotImplementedException();
    }

    public int FindPeakElement(int[] nums)
    {
        throw new NotImplementedException();
    }

    public bool IsArraySorted(int[] array)
    {
        throw new NotImplementedException();
    }

    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        foreach(var i in array)
            if(i > max)
                max = i;

        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        throw new NotImplementedException();
    }

    public int RemoveDuplicates(int[] array)
    {
        throw new NotImplementedException();
    }

    public int[] ReverseArray(int[] array)
    {
        for(int i = 0, j = array.Length - 1; i < j; i++, j--)
            (array[i], array[j]) = (array[j], array[i]);
        
        return array;
    }

    public void RotateArray(int[] array, int k)
    {
        throw new NotImplementedException();
    }

    public int[] SortArrayByParity(int[] nums)
    {
        throw new NotImplementedException();
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        throw new NotImplementedException();
    }
}