namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int FindMissingNumber(int[] nums)
    {
        var expectedSum = nums.Length * (nums.Length + 1) / 2;
        var actualSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            actualSum += nums[i];
        }
        return expectedSum - actualSum;
    }

    public int FindPeakElement(int[] nums)
    {
        var max = nums[0];
        foreach (var item in nums)
        {
            if (item > max)
            {
                max = item;
            }
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == max)
            {
                return i;
            }
        }

        return -1;

    }

    public bool IsArraySorted(int[] array)
    {
        for (var i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }


    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        foreach (var item in array)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    public int[] MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }

        return nums1;
    }


    public int RemoveDuplicates(int[] array)
    {
        List<int> uniqueNumbers = new List<int>();

        for (var i = 0; i < array.Length; i++)
        {
            var isUnique = true;
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                uniqueNumbers.Add(array[i]);
            }
        }

        for (var i = 0; i < uniqueNumbers.Count; i++)
        {
            array[i] = uniqueNumbers[i];
        }

        return uniqueNumbers.Count;
    }   

    public int[] ReverseArray(int[] array)
    {
        var reversedArray = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - i - 1];
        }
        return reversedArray;
    }

    public int[] RotateArray(int[] array, int k)
        {
            if (k == 0)
            {
                return array;
            }

            int lenghtOfArray = array.Length;

            void Reverse(int[] arrayToReverse, int start, int end)
            {
                while (start < end)
                {
                    int temp = arrayToReverse[start];
                    arrayToReverse[start] = arrayToReverse[end];
                    arrayToReverse[end] = temp;
                    start++;
                    end--;
                }
            }

            Reverse(array, 0, lenghtOfArray - 1);

            Reverse(array, 0, k - 1);

            Reverse(array, k, lenghtOfArray - 1);

            return array; 
        }

    public int[] SortArrayByParity(int[] nums)
    {
        var evenNumbers = new List<int>();
        var oddNumbers = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evenNumbers.Add(nums[i]);
            } 
            else 
            {
                oddNumbers.Add(nums[i]);
            }
        }

        for (var i = 0; i < oddNumbers.Count; i++)
        {
            evenNumbers.Add(oddNumbers[i]);
        }

        return evenNumbers.ToArray();
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        if (array is null || array.Length == 0)
        {
            throw new Exception();
        }

        long sum = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }

        if (sum < int.MinValue)
        {
            throw new OverflowException();
        }

        return (int)sum;
    }
}