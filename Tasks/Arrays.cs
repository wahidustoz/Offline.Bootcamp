using System.Text;

namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)
{
    double sum = 0;
    int count = 0;
    
    foreach (int[] arr in input)
    {
        foreach (int num in arr)
        {
            sum += num;
            count++;
        }
    }

    return sum/count; 
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


   public int FindMaxInJaggedArray(int[][] input)
{
    int max = input[0][0];
    
    foreach (int[] arr in input)
    {
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
    }

    return max;
}


    public int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
    int expectedSum = n * (n + 1) / 2; 
    int actualSum = 0;
    
    for (int i = 0; i < n; i++)
    {
        actualSum += nums[i];
    }

    return expectedSum - actualSum; 
    }

    public int FindPeakElement(int[] nums)
    {
         for(int i = 0; i < nums.Length; i++){
        if(i==0 &&nums[i] > nums[i + 1]){
            return i;
        }
        if(i == nums.Length - 1 && nums[i] > nums[i - 1]){
            return i;
        }
        if(nums[i] > nums[i + 1]&& nums[i] > nums[i - 1]){
            return i;
        }
       }
    return -1;
    }

    public int[] FlattenJaggedArray(int[][] input)
{
    List<int> flatList = new List<int>();
    
    foreach (int[] arr in input)
    {
        flatList.AddRange(arr);
    }

    return flatList.ToArray();
}


    public bool IsArraySorted(int[] array)
    {
         for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;   
            }
        }
        return true;
    }

public bool IsSymmetricMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);



    if (rows != cols)
    {
        return false;
    }

 
    for (int i = 0; i < rows; i++)
    {
        for (int j = i + 1; j < cols; j++) 
        {
            if (matrix[i, j] != matrix[j, i])
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
        
        for (int j = 0; j < input[i].Length; j++)
        {
            sb.Append(input[i][j]);
            if (j < input[i].Length - 1)
                sb.Append(",");
        }
        
        sb.Append("]");
        if (i < input.Length - 1)
            sb.Append(",");
    }
    
    sb.Append("]");
    return sb.ToString();
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
        for(int i =0,j = 0; i < nums1.Length; i++)
        {
            if(nums1[i] == 0)
            {
                nums1[i] = nums2[j];
                j++;
            }
        }
        Array.Sort(nums1);      
    }

    public int RemoveDuplicates(int[] array)
    {
        if (array.Length == 0) return 0;

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
    }    public int[] ReverseArray(int[] array)
    {
         for(int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return array;
    }

    public void RotateArray(int[] array, int k)
    {
           List<int> list = new List<int>();
      for(int i = array.Length - k; i < array.Length; i++){
        list.Add(array[i]);
      }
      for(int i = 0; i < array.Length - k; i++){    
        list.Add(array[i]);
      }
        for(int i = 0; i < array.Length; i++){
            array[i] = list[i];
        }
    }

   public int[,] RotateMatrix90Degrees(int[,] input)
{
    int rows = input.GetLength(0);
    int cols = input.GetLength(1);
    int[,] rotated = new int[cols, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            rotated[j, rows - i - 1] = input[i, j];
        }
    }

    return rotated;
}


    public int[] SortArrayByParity(int[] nums)
    {
         List<int> even = new List<int>();
       List<int> odd = new List<int>();
       foreach(int num in nums)
       {
        if(num % 2 == 0)
        {
            even.Add(num);
        }
        else
        {
            odd.Add(num);
        }
       }
       even.AddRange(odd);  
       return even.ToArray();
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


    public int SumOfEvenNumbers(int[] array)
    {
         if(array == null || array.Length == 0)
        {
            throw new Exception();
        }
        long sum = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        if(sum > int.MaxValue || sum < int.MinValue)
        {
            throw new OverflowException();
        }
        return (int)sum;
    }

  public int SumOfJaggedArray(int[][] input)
{
    int sum = 0;
    
    foreach (int[] arr in input)
    {
        foreach (int num in arr)
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