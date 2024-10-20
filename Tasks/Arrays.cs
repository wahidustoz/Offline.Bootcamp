using System.Data;

namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)
    {
        double sum=0;
        int count=0;
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input[i].Length;j++)
            {
                sum+=input[i][j];
                count++;
            }
        }
        return sum/count;
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int max=input[0,0];
        for(int i=0;i<input.GetLength(0);i++)
        {
            for(int j=0;j<input.GetLength(1);j++)
            {
                if(input[i,j]>max)
                    max=input[i,j];
            }
        }

        return max;
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        int max=input[0][0];
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input[i].Length;j++)
            {
                if(input[i][j]>max)
                {
                    max=input[i][j];
                }
            }
        }

        return max;
        
    }

    public int FindMissingNumber(int[] nums)
    {
    
        if(nums.Length==1 && nums[0]==0) return 1;
        var min=nums.Min();
        var max=nums.Max();
        var sumNums=0;
        for(int i=min;i<=max;i++)
        {
            sumNums+=i;
        }
        var sumArr=nums.Sum();
        if(nums[0]==0 && sumNums==sumArr) return max+1;
        return sumNums-sumArr;
    }

    public int FindPeakElement(int[] nums)
    {
        var max=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]>nums[max])
                max=i;
        }
        return max;
    }

    public int [] FlattenJaggedArray(int[][] input)
    {
        int count=0;
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input[i].Length;j++)
                count++;
        }
        int[] flattened = new int[count];
        int idx=0;
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input[i].Length;j++)
            {
                flattened[idx]=input[i][j];
                idx++;
            }
                
        }

        return flattened;
    }

    public bool IsArraySorted(int[] array)
    {
        var sorted = true;
        for(int i=0;i<array.Length-1;i++)
        {
            if(array[i]>array[i+1])
            {
                sorted = false;
                break;
            }
        }
        return sorted;
    }

    public bool IsSymmetricMatrix(int[,] input)
    {
        bool check=true;

        if(input.GetLength(0)!=input.GetLength(1))
            return false;

        for(int i=0;i<input.GetLength(0);i++)
        {
           if(input[0,i]!=input[i,0])
                        check=false;
        }
        return check;
    }

    public string? JaggedArrayToString(int[][] input)
    {
        string? jaggedString ="[";
        if(input.Length==0)
            return "[]";

        for(int i=0;i<input.Length;i++)
        {
            jaggedString+="[";
            if(input[i].Length!=0)
            {
                int j=0;
            for(;j<input[i].Length-1;j++)
            {
                jaggedString+=input[i][j].ToString()+",";
            }
            jaggedString+=input[i][j].ToString()+"]";
            }
            else
            {
                jaggedString+="]";
            }
            if(i!=input.Length-1)
                jaggedString+=",";
            
        }
        jaggedString+="]";

        return jaggedString;
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
        int [] merged = new int[m+n];
        for(int i=0;i<m;i++)
        {
            merged[i] = nums1[i];
        }
        for(int i=0;i<n;i++)
        {
            merged[m+i] = nums2[i];
        }
        Array.Sort(merged);
        for(int i=0;i<m+n;i++)
        {
            nums1[i] = merged[i];
        }
        return nums1;
    }

    public int RemoveDuplicates(int[] array)
    {
        
        if(array.Length==0) return 0;
        int count=1;
       for(int i=1;i<array.Length;i++)
       {
           if(array[i-1]!=array[i])
           {
               array[count]=array[i];
               count++;
           }
       }
        return count;
    }

    public int[] ReverseArray(int[] array)
    {
        var reversed = new int[array.Length];
        for(int i=array.Length-1;i>=0;i--)
        {
            reversed[array.Length - i - 1] = array[i];
        }
        return reversed;
    }

    public int[] RotateArray(int[] array, int k)
    {
        
        int[] rotated = new int[array.Length];
        for(int i=0;i<array.Length;i++)
        {
            rotated[(i+k)%array.Length] = array[i];
        }
        for(int i=0;i<array.Length;i++)
        {
            array[i] = rotated[i];
        }
        return array;
    }

    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        int[,] input90= new int [input.GetLength(1),input.GetLength(0)];

       for(int i=0;i<input.GetLength(0);i++)
       {
            for(int j=0;j<input.GetLength(1);j++)
            {
                
                input90[j,input.GetLength(0)-i-1]=input[i,j];
            }
       } 

       return input90;
    }
    public int[] SortArrayByParity(int[] nums)
    {

        int[] even = new int[nums.Length];
        int[] odd = new int[nums.Length];
        int evenIndex = 0;
        int oddIndex = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]%2==0)
            {
                even[evenIndex++] = nums[i];
            }
            else
            {
                odd[oddIndex++] = nums[i];
            }
        }
        for(int i=0;i<evenIndex;i++)
        {
            nums[i] = even[i];
        }
        for(int i=0;i<oddIndex;i++)
        {
            nums[evenIndex+i] = odd[i];
        }
        return nums;
    }

    public int SumOfDiagonalElements(int[,] input)
    {

        int sum=0;
        // Console.WriteLine(input.Length);
        for(int i=0;i<input.GetLength(0);i++)
        {
            sum+=input[i,i];
        }
        return sum;
    }

    public int  SumOfEvenNumbers(int[] array)
    {
        if (array == null || array.Length == 0)
                throw new Exception("Array bo'sh yoki null");

            // Juft sonlarni yig'indisini hisoblash
            return array.Where(n => n % 2 == 0).Sum();
    }

    public int SumOfJaggedArray(int[][] input)
    {
        int sum=0;
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input[i].Length;j++)
            {
                sum+=input[i][j];
            }
        }

        return sum;
    }

    public int[,] TransposeMatrix(int[,] input)
    {
        int[,] transposeMatrix=new int [input.GetLength(1),input.GetLength(0)];
        for(int i=0;i<input.GetLength(0);i++)
        {
            for(int j=0;j<input.GetLength(1);j++)
            {
                transposeMatrix[j,i]=input[i,j];
            }
        }

        return transposeMatrix;
    }
}