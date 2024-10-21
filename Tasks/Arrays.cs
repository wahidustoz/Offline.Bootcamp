using System.Text;

namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)
    {
        int sum = 0;
        int count = 0;
        foreach (var array in input)
        {
            foreach (var num in array)
            {
                sum += num;
                count++;
            }
        }
        return count > 0 ? (double)sum / count : 0;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int maxElement = input[0, 0];
        for (int row = 0; row < input.GetLength(0); row++)
        {
            for (int col = 0; col < input.GetLength(1); col++)
            {
                if (input[row, col] > maxElement)
                {
                    maxElement = input[row, col];
                }
            }
        }
        return maxElement;
    }

    public int FindMaxInJaggedArray(int[][] input)
    {

        int maxElement = int.MinValue;

        foreach (var array in input)
        {
            foreach (var num in array)
            {
                if (num > maxElement)
                {
                    maxElement = num;
                }
            }
        }
        return maxElement;
    }

    public int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sum = n * (n + 1) / 2;
        int sumArray = 0;
        foreach (int num in nums)
        {
            sumArray += num;
        }
        return sum - sumArray;
    }

    public int FindPeakElement(int[] nums)
    {
        int max = nums[0];
        int index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                index = i;
            }
        }
        return index;
    }

    public int[] FlattenJaggedArray(int[][] input)
    {
        var result = new List<int>();
        foreach (var array in input)
        {
            result.AddRange(array);
        }
        return result.ToArray();

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

    public bool IsSymmetricMatrix(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);
        if (rows != cols)
        {
            return false;
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                if (input[i, j] != input[j, i])
                {
                    return false;
                }

            }
        }
        return true;

    }

    public string JaggedArrayToString(int[][] input)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append("[");
            if (input[i].Length > 0)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    sb.Append(input[i][j]);
                    if (j < input[i].Length - 1)
                    {
                        sb.Append(",");
                    }
                }
            }
            sb.Append("]");
            if (i < input.Length - 1)
            {
                sb.Append(",");
            }
        }
        sb.Append("]");
        return sb.ToString();
    }

    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        foreach (var i in array)
            if (i > max)
                max = i;

        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0, j = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == 0)
            {
                nums1[i] = nums2[j];
                j++;
            }
        }
        Array.Sort(nums1);
    }

    public int RemoveDuplicates(int[] array)
    {
        if (array is null or { Length: 0 })
            return 0;
        int dub = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[dub - 1])
            {
                array[dub] = array[i];
                dub++;
            }
        }
        return dub;
    }

    public int[] ReverseArray(int[] array)
    {
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            (array[i], array[j]) = (array[j], array[i]);
        return array;

    }

    public void RotateArray(int[] array, int k)
    {
        var list = new List<int>();
        for (int i = array.Length - k; i < array.Length; i++)
        {
            list.Add(array[i]);
        }
        for (int i = 0; i < array.Length - k; i++)
        {
            list.Add(array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = list[i];
        }
    }

    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        var yangiInput = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                yangiInput[j, rows - i - 1] = input[i, j];
            }
        }

        return yangiInput;
    }

    public int[] SortArrayByParity(int[] nums)
    {
        var juft = new List<int>();
        var toq = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                juft.Add(nums[i]);
            }
            else
            {
                toq.Add(nums[i]);
            }
        }
        juft.AddRange(toq);
        return juft.ToArray();
    }

    public int SumOfDiagonalElements(int[,] input)
    {
        int sumDio = 0;

        for (int i = 0; i < input.GetLength(0); i++)
        {
            sumDio += input[i, i];
        }
        return sumDio;
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        if (array is null or { Length: 0 })
        {
            throw new ArgumentException("xato");
        }
        long sumEven = 0;
        foreach (int son in array)
        {
            if (son % 2 == 0)
            {
                sumEven += son;
            }
        }
        if (sumEven < int.MinValue || sumEven > int.MaxValue)
        {
            throw new OverflowException("sum oshib ketti");
        }
        return (int)sumEven;
    }

    public int SumOfJaggedArray(int[][] input)
    {
        int sum = 0;
        foreach (var array in input)
        {
            foreach (var num in array)
            {
                sum += num;
            }
        }
        return sum;
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        var yangiInput = new int[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                yangiInput[j, i] = input[i, j];
            }

        return yangiInput;
    }
}