namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int MaxValueInArray(int[] array)
    {
        if (array.Length > 0)
        {
            var max = array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];

            return max;
        }
        return 0;
    }

    public int[] ReverseArray(int[] array)
    {
        if (array.Length > 0)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
                (array[i], array[j]) = (array[j], array[i]);
            return array;
        }
        return [];
    }

    public bool IsArraySorted(int[] array)
    {
        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                    return false;

            return true;
        }
        return true;
    }

    public object SumOfEvenNumbers(int[]? array)
    {
        if (array is null)
            throw new NullReferenceException();

        if (array.Length == 0)
            throw new IndexOutOfRangeException();

        int sumELements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                checked
                {
                    sumELements += array[i];
                }
            }
        }
        return sumELements;
    }

    public int RemoveDuplicates(int[] array)
    {
        if (array.Length == 0)
            return 0;

        List<int> list = [array[0]];

        for (int i = 1, j = 1; i < array.Length; i++)
        {
            if (!IsContain(list, array[i]))
            {
                array[j] = array[i];
                list.Add(array[i]);
                j++;
            }
        }

        for (int i = list.Count; i < array.Length; i++)
            array[i] = 0;

        return list.Count;
    }

    private bool IsContain(List<int> array, int element)
    {
        foreach (int item in array)
            if (item == element)
                return true;

        return false;
    }

    public void RotateArray(int[] array, int k)
    {
        List<int> returnArray = new List<int>();
        for (int i = array.Length - k; i < array.Length; i++)
        {
            returnArray.Add(array[i]);
        }
        for (int i = 0; i < array.Length - k; i++)
        {
            returnArray.Add(array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = returnArray[i];
        }
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int p = m + n - 1;

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }
        while (p2 >= 0)
        {
            nums1[p] = nums2[p2];
            p--;
            p2--;
        }
    }

    public int FindMissingNumber(int[] nums)
    {
        if (nums.Length > 1)
        {
            bool continueValue = true;
            while (continueValue)
            {
                continueValue = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swap(nums, i, i + 1);
                        continueValue = true;
                    }
                }
            }

            for (int i = 0; i < nums.Length - 1; i++)
                if ((nums[i + 1] - nums[i]) != 1)
                    return nums[i] + 1;
        }

        if (nums[0] != 0)
            return 0;

        return nums[nums.Length - 1] + 1;
    }

    private void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public int FindPeakElement(int[] nums)
    {
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > max)
                max = i;

        return max;
    }

    public int[] SortArrayByParity(int[] nums)
    {
        if (nums.Length == 0)
            return [];

        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
                evenNumbers.Add(nums[i]);

            else
                oddNumbers.Add(nums[i]);
        }
        evenNumbers.AddRange(oddNumbers);

        return evenNumbers.ToArray();
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        if (input.Length == 0)
            return new int[,] { };

        int[,] transposeMatrix = new int[input.GetLength(1), input.GetLength(0)];

        for (int i = 0; i < input.GetLength(1); i++)
            for (int j = 0; j < input.GetLength(0); j++)
                transposeMatrix[i, j] = input[j, i];

        return transposeMatrix;
    }

    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        if (input.Length == 0)
            return new int[,] { };

        int[,] rotateMatrix90Degrees =
            new int[input.GetLength(1), input.GetLength(0)];

        for (int i = 0; i < input.GetLength(1); i++)
        {
            for (int j = 0; j < input.GetLength(0); j++)
            {
                rotateMatrix90Degrees[i, j] = input[input.GetLength(0) - 1 - j, i];
            }
        }
        return rotateMatrix90Degrees;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        if (input.Length == 1)
            return input[0, 0];

        int max = input[0, 0];
        for (int i = 0; i < input.GetLength(0); i++)
            for (int j = 0; j < input.GetLength(1); j++)
                if (input[i, j] > max)
                    max = input[i, j];

        return max;

    }

    public int SumOfDiagonalElements(int[,] input)
    {
        if (input.Length == 1)
            return input[0, 0];

        int sumDiagonalElements = 0;

        for (int i = 0; i < input.GetLength(0); i++)
            sumDiagonalElements += input[i, i];

        return sumDiagonalElements;
    }

    public bool IsSymmetricMatrix(int[,] input)
    {
        if (input.Length < 2)
            return true;

        if (input.GetLength(0) != input.GetLength(1))
            return false;

        for (int i = 0; i < input.GetLength(0); i++)
            for (int j = 0; j < input.GetLength(1); j++)
                if (i != j && (input[i, j] != input[j, i]))
                    return false;

        return true;
    }

    public int[] FlattenJaggedArray(int[][] input)
    {
        if (input.Length == 0)
            return new int[] { };

        List<int> flattenArray = new List<int>();
        for (int i = 0; i < input.Length; i++)
            if (input[i].Length != 0)
                for (int j = 0; j < input[i].Length; j++)
                    flattenArray.Add(input[i][j]);

        return flattenArray.ToArray();
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        int max = input[0][0];
        for (int i = 0; i < input.Length; i++)
            for (int j = 0; j < input[i].Length; j++)
                if (input[i][j] > max)
                    max = input[i][j];

        return max;
    }

    public int SumOfJaggedArray(int[][] input)
    {
        int sumOfNumbers = 0;

        if (input.Length == 0)
            return 0;

        for (int i = 0; i < input.Length; i++)
            if (input[i].Length != 0)
                for (int j = 0; j < input[i].Length; j++)
                    sumOfNumbers += input[i][j];

        return sumOfNumbers;
    }

    public double AverageOfJaggedArray(int[][] input)
    {
        if (input.Length == 0)
            return 0;

        int inputFullLength = 0;
        for (int i = 0; i < input.Length; i++)
            if (input[i].Length != 0)
                inputFullLength += input[i].Length;

        double averageOfJaggedArray =
            (double)SumOfJaggedArray(input) / inputFullLength;

        return averageOfJaggedArray;
    }

    public string JaggedArrayToString(int[][] input)
    {
        if (input.Length == 0)
            return "[]";

        string[] subArrayStringForm = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
            subArrayStringForm[i] = $"[{string.Join(',', input[i])}]";

        return $"[{string.Join(',', subArrayStringForm)}]";
    }
}