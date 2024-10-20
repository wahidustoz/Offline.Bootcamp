namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int FindMissingNumber(int[] nums)
    {
        int length = nums.Length;
        int totalSum = length * (length + 1) / 2;
        int sum = 0;
        foreach (var i in nums)
        {
            sum += i;
        }
        return totalSum - sum;
    }

    public int FindPeakElement(int[] nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return nums.ToList().IndexOf(max);
    }

    public bool IsArraySorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
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
        foreach (var i in array)
        {
            if (i > max)
            {
                max = i;

            }
        }
        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
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
    }


    public int[]? ReverseArray(int[]? array)
    {
        if (array == null)
            return null;
        return array.Reverse().ToArray();
    }

    public int[] RotateArray(int[] array, int k)
    {
        while (k > 0)
        {
            int temp = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
            k--;
        }
        return array;
    }

    public int[] SortArrayByParity(int[] nums)
{
    int[] result = new int[nums.Length];
    int evenIndex = 0;
    int oddIndex = nums.Length - 1;
    foreach (int num in nums)
    {
        if (num % 2 == 0)
        {
            result[evenIndex] = num;
            evenIndex++;
        }
    }

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        if (nums[i] % 2 != 0)
        {
            result[oddIndex] = nums[i];
            oddIndex--;
        }
    }

    return result;
}

    public int SumOfEvenNumbers(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new Exception();
        int sum = 0;
        foreach (var i in array)
        {
            if (i % 2 == 0)
            {
                checked
                {
                    sum += i;
                }
            }
        }
        return sum;
    }

    public static int RemoveDuplicates(int[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        int uniqueIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[uniqueIndex])
            {
                uniqueIndex++;
                array[uniqueIndex] = array[i];
            }
        }

        return uniqueIndex + 1;
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        int[,] result = new int[input.GetLength(1), input.GetLength(0)];
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                result[j, i] = input[i, j];
            }
        }
        return result;
    }

    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);
        int[,] result = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, rows - i - 1] = input[i, j];
            }
        }

        return result;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int max = input[0, 0];
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (input[i, j] > max)
                {
                    max = input[i, j];
                }
            }
        }
        return max;
    }

    public int SumOfDiagonalElements(int[,] input)
    {
        int sum = 0;
        for (int i = 0; i < input.GetLength(0); i++)
        {
            sum += input[i, i];
        }
        return sum;
    }

    public bool IsSymmetricMatrix(int[,] input)
    {

        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        if (rows != cols)
            return false;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (input[i, j] != input[j, i])
                    return false;
            }
        }

        return true;
    }

    public int[] FlattenJaggedArray(int[][] input)
    {
        return input.SelectMany(arr => arr).ToArray();
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        int max = input[0][0];
        foreach (var i in input)
        {
            foreach (var j in i)
            {
                if (j > max) max = j;
            }
        }
        return max;
    }

    public int SumOfJaggedArray(int[][] input)
    {
        int sum = 0;
        foreach (var i in input)
        {
            foreach (var j in i)
            {
                sum += j;
            }
        }
        return sum;
    }

    public double AverageOfJaggedArray(int[][] input)
    {
        double sum = 0;
        int count = 0;
        foreach (var i in input)
        {
            foreach (var j in i)
            {
                sum += j;
                count++;
            }
        }
        return sum / count;
    }

    public string JaggedArrayToString(int[][] input)
    {
        return $"[{string.Join(",", input.Select(arr => $"[{string.Join(",", arr)}]"))}]";
    }
}