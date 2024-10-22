
namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public int MaxValueInArray(int[] array)
    {
        int maxValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
                maxValue = array[i];
        }

        return maxValue;
    }
    public int[] ReverseArray(int[] array)
    {
        int temp = 0;
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        return array;
    }

    public bool IsArraySorted(int[] array)
    {
        if (array.Length == 0) return true;
        int value = array[0];
        foreach (var item in array)
        {
            if (item < value) return false;
            value = item;
        }

        return true;
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                if (array[i] > 0 && sum > int.MaxValue - array[i])
                    throw new OverflowException();


                if (array[i] < 0 && sum < int.MinValue - array[i])
                    throw new OverflowException();
                sum += array[i];

            }
        }

        return sum;

    }

    public int RemoveDuplicates(int[] array)
    {
        //some problem
        if (array.Length == 0)
            return 0;

        int index = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[index - 1])
            {
                array[index] = array[i];
                index++;
            }
        }

        return index;

    }

    public void RotateArray(int[] array, int k)
    {
        //some problem
        throw new Exception();
    }

    public int[] MergeSortedArrays(int[] array1, int m, int[] array2, int n)
    {
        //some problem
        //int o = m - 1;
        //int j = n - 1;
        //int k = m + n - 1;

        //while (i >= 0 && j >= 0)
        //{
        //    if (array1[i] > array2[j])
        //    {
        //        array1[k--] = array2[i--];
        //    }
        //    else
        //    {
        //        array1[k--] = array2[j--];
        //    }
        //}
        bool ozgar = true;

        while (ozgar)
        {
            ozgar = false;
            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i - 1] > array1[i])
                {
                    var temp = array1[i];
                    array1[i] = array1[i - 1];
                    array1[i - 1] = temp;
                    ozgar = true;
                }/// 1 5 7 2 68  
            }

        }

        //while (j >= 0)
        //{
        //    array1[k--] = array2[j--];
        //}
        return array1;
        throw new Exception();
    }

    public int FindMissingNumber(int[] array)
    {
        int check = 0;
        for (int i = 0; i < array.Length + 1; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == array[j])
                {
                    check = -1;
                    break;
                }
            }

            if (check == 0)
                return i;

            check = 0;

        }
        return 0;
    }

    public int FindPeakElement(int[] array)
    {
        int indexOfPeak = 0, peak = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (peak < array[i])
            {
                peak = array[i];
                indexOfPeak = i;
            }
        }
        return indexOfPeak;
    }

    public int[] SortArrayByParity(int[] array)
    {
        if (array.Length == 0) return new int[] { };
        int pointer = 0, temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                temp = array[pointer];
                array[pointer] = array[i];
                array[i] = temp;
                pointer++;
            }
        }
        return array;

    }
    public double AverageOfJaggedArray(int[][] input)
    {
        if (input == null || input.Length == 0) return 0;
        var elements = input.SelectMany(innerArray => innerArray).ToArray();
        return elements.Average();
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        //some problem
        if (input == null || input.GetLength(0) == 0 || input.GetLength(1) == 0)
        {
            throw new ArgumentException("The matrix cannot be null or empty.");
        }

        int largest = input[0, 0];

        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (input[i, j] > largest)
                {
                    largest = input[i, j];
                }
            }
        }

        return largest;
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        //some problem
        if (input == null || input.Length == 0)
        {
            throw new ArgumentException("The jagged array cannot be null or empty.");
        }

        int max = int.MinValue;

        foreach (var array in input)
        {
            if (array != null)
            {
                foreach (var num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
        }

        return max;
    }


    public int[] FlattenJaggedArray(int[][] input)
    {
        return input.SelectMany(innerArray => innerArray).ToArray();
    }



    public bool IsSymmetricMatrix(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        if (rows != cols) return false;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (input[i, j] != input[j, i])
                    return false;
            }
        }

        return true;
    }

    public string JaggedArrayToString(int[][] input)
    {
        if (input == null || input.Length == 0) return "[]";
        return "[" + string.Join(",", input.Select(innerArray => "[" + string.Join(",", innerArray) + "]")) + "]";
    }







    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int n = input.GetLength(0); // Matritsaning o�lchami (N x N)
        int[,] rotated = new int[n, n]; // Natijaviy aylantirilgan matritsa

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rotated[j, n - i - 1] = input[i, j];
            }
        }

        return rotated;
    }



    public int SumOfDiagonalElements(int[,] input)
    {
        int n = input.GetLength(0); 
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += input[i, i]; 
        }

        return sum;
        throw new NotImplementedException();
    }



    public int SumOfJaggedArray(int[][] input)
    {
        int sum = 0;
        foreach (var innerArray in input)
        {
            foreach (var num in innerArray)
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
        int[,] transposed = new int[cols, rows]; 

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = input[i, j];
            }
        }
        return transposed;
    }




}