

namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)
    {
        var sum = 0.0;
        var length = 0;

        for (var i = 0; i < input.Length; i++)
        {
            length += input[i].Length;
            for (var j = 0; j < input[i].Length; j++)
            {
                sum += input[i][j];
            }
        }
        return sum / length;
    }
    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        int[,] rotatedArray = new int[cols, rows];

        // Rotate the matrix
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                rotatedArray[j, rows - i - 1] = input[i, j];
            }
        }

        return rotatedArray;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        int maxValue = input[0, 0] < 0 ? int.MinValue : 0;


        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (maxValue < input[i, j])
                {
                    maxValue = input[i, j];
                }
            }
        }
        return maxValue;
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        var maxValue = input[0][0];
        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input[i].Length; j++)
            {
                if (maxValue < input[i][j])
                {
                    maxValue = input[i][j];
                }
            }
        }
        return maxValue;
    }

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

    public int[] FlattenJaggedArray(int[][] input)
    {
        List<int> flattenedJaggedArray = [];

        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input[i].Length; j++)
            {
                flattenedJaggedArray.Add(input[i][j]);
            }
        }

        return flattenedJaggedArray.ToArray();
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

    public bool IsSymmetricMatrix(int[,] input)
    {
        if (input.GetLength(0) != input.GetLength(1))
            return false;

        for (var i = 0; i < input.GetLength(1); i++)
        {
            for (var j = 0; j < input.GetLength(1); j++)
            {
                if (input[j, i] != input[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public string JaggedArrayToString(int[][] input)
    {
        var result = "[";
        for (var i = 0; i < input.Length; i++)
        {
            result += "[";
            for (var j = 0; j < input[i].Length; j++)
            {
                result += $"{input[i][j]}";
                if (j != input[i].Length - 1)
                {
                    result += ",";
                }
            }
            result += "]";
            
            if (i != input.Length - 1)
                {
                    result += ",";
                }
        }
            result += "]";
        
        return result;
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

    public int SumOfDiagonalElements(int[,] input)
    {
        var sum = input[0, 0];
        for (var i = 1; i < input.GetLength(0); i++)
        {
            Console.WriteLine(sum);
            sum += input[i, i];
        }

        return sum;
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

    public int SumOfJaggedArray(int[][] input)
    {
        var sum = 0;

        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input[i].Length; j++)
            {
                sum += input[i][j];
            }
        }

        return sum;
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        var result = new int[input.GetLength(1), input.GetLength(0)];
        for (var i = 0; i < input.GetLength(0); i++)
        {
            for (var j = 0; j < input.GetLength(1); j++)
            {
                result[j, i] = input[i, j];
            }
        }
        return result;
    }
}