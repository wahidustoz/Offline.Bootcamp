namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)
    {
        double sum = 0;
        int len = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                sum += input[i][j];
                len++;
            }
        }
        if (sum == 0)
            return 0;
        return sum / len;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int max = input[0,0];
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (max < input[i, j]) max = input[i, j];
            }
        }
        return max;
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        int max = input[0][0];
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                if (max < input[i][j]) max = input[i][j];
            }
        }
        return max;
    }

    public int FindMissingNumber(int[] nums)
    {
        Array.Sort(nums);
        int res = 0; 
        for (int i = 0; i < nums.Length + 1; i++)
        {
            if (!nums.Contains(i))
            {
                res = i;
                break;
            }
        }
        return res;
    }

    public int FindPeakElement(int[] nums)
    {
        int res = 0;
        int max = nums[0];
    
        for (int i = 1; i < nums.Length -1 ; i++)
        {
            if (nums[i] > nums[i-1] && nums[i] > nums[i+1] && nums[i] > max)
            {
                res = i;
                max = nums[i];
            }
        }

        if (nums[0] > nums[1] && nums[0] > max)
            return 0;
        if (nums[nums.Length - 1] > nums[nums.Length - 2] && nums[nums.Length - 1] > max) 
            return nums.Length - 1;

        return res;
    }

    public int[] FlattenJaggedArray(int[][] input)
    {
        int len = 0;
        for (int i = 0; i < input.Length; i++)
        {
                len += input[i].Length;
        }

        int[] res = new int[len];
        int index = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                res[index] = input[i][j];
                index++;
            }
        }
        return res;
    }

    public bool IsArraySorted(int[] array)
    {
        if (array.Length == 0 || array.Length == 1)
            return true;
        var max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(max <= array[i])
            {
                max = array[i];
            }
            else
            {
                return false;
            }        
        }
        return true;
    }

    public bool IsSymmetricMatrix(int[,] input)
    {
        if (input.GetLength(0) == 0 || input.GetLength(1) == 0)
            return true;
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);
        bool res = rows != cols ? false : true;
        return res;
    }

    public string JaggedArrayToString(int[][] input)
    {
        if (input == null || input.Length == 0)
        {
            return "[]"; // Return a string indicating the array is empty
        }

        // Create the string representation in compact format
        return "[" + string.Join(",", input.Select(innerArray => "[" + string.Join(",", innerArray) + "]")) + "]";
    }

    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        for(int i =0; i<array.Length; i++)
        {
            if(max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;  
        int j = n - 1;  
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
        
        Console.WriteLine(string.Join(", ", nums1));
    }

    public int RemoveDuplicates(int[] array)
    {
        // HashSet<int> num = new(array);
        // int[] arr = num.ToArray();
        // return arr.Length;  
        if (array == null || array.Length == 0)
        {
            return 0; // Return 0 for null or empty array
        }

        HashSet<int> numSet = new();
        foreach (int number in array)
        {
            numSet.Add(number); // Add elements to the HashSet for uniqueness
        }

        // Copy unique elements back to the original array
        int index = 0;
        foreach (int number in numSet)
        {
            array[index++] = number; // Place unique elements back into the array
        }

        return numSet.Count; 
    }

    public IEnumerable<int> ReverseArray(int[] array)
    {
        int[] reverese = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reverese[i]=array[array.Length - 1 -i];
        }
        return reverese;
    }

    public void RotateArray(int[] array, int k)
    {
        if(array.Length == 0)
        {
            Console.WriteLine(array);
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                RotateArrayK(array , k);
            }
        }
        
    }
    public void RotateArrayK(int[] array, int k)
    {
        int temp = array[array.Length - 1];
        for (int i = array.Length-2; i >= 0; i--)
        {
            array[i + 1] = array[i];    
        }
        array[0] = temp;
        Console.WriteLine(array);
    }

    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int rows = input.GetLength(0); 
        int cols = input.GetLength(1); 
        int[,] rotatedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotatedMatrix[j, rows - 1 - i] = input[i, j];
            }
        }

        return rotatedMatrix;
    }

    public IEnumerable<int>? SortArrayByParity(int[] nums)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int temp = 0;
                if (nums[i] % 2 != 0)
                {
                    temp = nums[i];
                    nums[i] = nums[i+1];
                    nums[i+1] = temp;
                }
            }
        }

        return nums;
    }

    public int SumOfDiagonalElements(int[,] input)
    {
        int sum = 0;
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (i == j)
                    sum += input[i, j];
            }
        }

        return sum;
    }

    public int SumOfEvenNumbers(int[] array)
    {
        // throw new NotImplementedException();
        int sum = 0;
        checked{
            for (int i = 0; i < array.Length; i++ )
            {
                if(array[i] % 2 == 0)
                {   
                    sum = checked(sum + array[i]);
                }
            }
        }
        return sum;
    }

    public int SumOfJaggedArray(int[][] input)
    {
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                sum += input[i][j];
            }
        }
        return sum;
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1); 

        int[,] transposedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = input[i, j];
            }
        }

        return transposedMatrix;
    }

}