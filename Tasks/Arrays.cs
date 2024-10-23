

















using System.Buffers;
using System.ComponentModel;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;

namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    
    public double AverageOfJaggedArray(int[][] input)
    {
        double sum=0;
        int count=0;
        
        foreach(var array in input)
        {
            sum+=array.Sum();
            count+=array.Length;
        }

        return sum/count;  // 100 %
    }

    public int FindLargestElementInMatrix(int[,] input)
    {
        int max=input[0, 0];
        for(int i=0; i<input.GetLength(0); i++)
        {
            for(int j=0; j<input.GetLength(1); j++)
            {
                if(input[i, j]>max)
                max=input[i, j];
            }
        }
        return max;     //  100 %
    }

    public int FindMaxInJaggedArray(int[][] input)
    {
        int max=input[0][0];
        foreach(var array in input)
        {
            foreach(var element in array)
            if(element > max)
                max=element;    
        }

        return max;  // 100 %
    }

    public int FindMissingNumber(int[] nums)
    {
        int sum=nums[0], max=nums[0];
        for(int i=1; i<nums.Length; i++)
        {
            sum+=nums[i];
            if(nums[i]>max)
            max=nums[i];
        }

        if((max+1)*max/2==sum)
        {
            if(nums.Length==max)
            return 0;
            else
            return max+1;
        }
        return (max+1)*max/2-sum; //100%

    }

    public int FindPeakElement(int[] nums)
    {
        int max=nums[0], index=0;
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i]>max)
            {
                max=nums[i];
                index=i;
            }
        }
        return index;       //100%
    }

    public int[] FlattenJaggedArray(int[][] input)  
    {

        if(input == null || input.Length == 0)
            return [];
        
        int size=0;

        foreach(var array in input)
            size+=array.Length;

        int[] newarray = new int[size];
        int index=0;

        foreach(var array in input)
        {
                foreach(var elements in array)
                {
                    newarray[index++]=elements;
                }
        }

        return newarray;           // 100 %
    }

    public bool IsArraySorted(int[] array)
    {
        if(array==null)
            return true;

        for(int i=0; i<array.Length-1; i++)
        {
            if(array[i+1]<array[i])
            return false;
        }
        return true;
    }

    public bool IsSymmetricMatrix(int[,] input)
    {

        if(input.Length==0)
            return true;

        if(input.GetLength(0)!=input.GetLength(1))
            return false;

        for(int i=0; i<input.GetLength(0); i++)
        {
            for(int j=0; j<input.GetLength(1); j++)
            {
                if(input[i, j]!=input[j, i])
                    return false;
            }
        }
        return true;   // 100 %
    }

    public string JaggedArrayToString(int[][] input)
    {
        if(input == null || input.Length==0)
            return "[]";

        return "[" + string.Join(",", input.Select(arr => "[" + string.Join(",", arr) + "]")) + "]";    // 100 % 
    }

    public int MaxValueInArray(int[] array)
    {
        var max = array[0];
        foreach(var i in array)
            if(i > max)
                max = i;

        return max; // 100 %
    }

    public int[] MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1; // Last index of the first array's valid elements
    int j = n - 1; // Last index of the second array
    int k = m + n - 1; // Last index of the merged array

    // Merge the arrays starting from the end
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

    // If there are remaining elements in nums2, copy them
    while (j >= 0)
    {
        nums1[k] = nums2[j];
        j--;
        k--;
    }

    return nums1; // 100 %
}

    public int RemoveDuplicates(int[] array)
    {
        if (array.Length == 0)
            return 0;

        // Takrorlanmas elementlar uchun index
        int uniqueIndex = 0;

        // Massivni boshidan oxirigacha ko'rib chiqamiz
        for (int i = 1; i < array.Length; i++)
        {
            // Agar hozirgi element avvalgi elementdan farqli bo'lsa
            if (array[i] != array[uniqueIndex])
            {
                uniqueIndex++;         // Indeksni oshiramiz
                array[uniqueIndex] = array[i];  // Takrorlanmagan elementni joylashtiramiz
            }
        }

        // Takrorlanmagan elementlar sonini qaytaramiz
        return uniqueIndex + 1;
    }

    public int[] ReverseArray(int[] array)
    {
        if(array.Length == 0)
        {
            return [];    
        }
    for(int i=0, j=array.Length-1; i<j; i++, j--)
        {
            (array[j], array[i])=(array[i], array[j]);
        }
    return array;  //  100 %
    }
    private void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            (array[start], array[end]) = (array[end], array[start]);
            start++;
            end--;
        }
    }
    public int[] RotateArray(int[] array, int k)
    {
        if (array.Length == 0 || k == 0)
            return array;

        // K ning qiymatini massiv uzunligidan katta bo'lishini oldini olish
        k = k % array.Length;

        // Uch bosqichda massivni aylantiramiz
        Reverse(array, 0, array.Length - 1); // Butun massivni teskari qilish
        Reverse(array, 0, k - 1);           // Birinchi k qismni teskari qilish
        Reverse(array, k, array.Length - 1); // Qolgan qismini teskari qilish

        // O'zgartirilgan massivni qaytaramiz
        return array; // 100 %
    }


    public int[,] RotateMatrix90Degrees(int[,] input)
    {
        if(input==null || input.Length==0)
            return new int[0, 0];

        int[,] newarray = new int[input.GetLength(1), input.GetLength(0)];
        for(int j=input.GetLength(1)-1; j>=0; j--)
        {
            for(int i=0; i<input.GetLength(0); i++)
            {
                newarray[j, input.GetLength(0)-i-1]=input[i, j];
            }
        }
        return newarray;     // 100 %
    }

    public int[] SortArrayByParity(int[] nums)
    {
        if(nums.Length==0)
        return [];

        int z;
        for(int i=1; i<nums.Length; i++)
        {
            z=i;
            if(nums[z]%2==0 && nums[z-1]%2==1)
            {
                while(z != 0)
                {                   
                    int tamp=nums[z-1];
                    nums[z-1]=nums[z];
                    nums[z]=tamp;
                    z--;
                    if(z-1>=0 && nums[z-1]%2==1)
                    continue;
                    else
                    break;
                }
            }
        }

        return nums;        // 100%
    }

    public int SumOfDiagonalElements(int[,] input)
    {
        int sum=0;
        for(int i=0; i<input.GetLength(0); i++)
        {
            for(int j=0; j<input.GetLength(1); j++)
            {
                if(i==j)
                    sum+=input[i, j];   

            }
        }
        return sum;   // 100 %
    }

    public int SumOfEvenNumbers(int[]? array)
    {
        if(array==null || array.Length==0)
        throw new Exception("Xato");

        int sum=0;
        foreach(int i in array)
        {
            if(i%2==0)
            sum=checked(sum+i);
        }
        return sum;
    }

    public int SumOfJaggedArray(int[][] input)
    {
        if(input == null || input.Length == 0)
            return 0;
        
        int sum=0;

        foreach(var array in input)
        {
            foreach(var element in array)
            {
                sum += element;
            }
        }
        return sum; //  100 %
    }

    public int[,] TransposeMatrix(int[,] input)
    {

        if(input==null || input.Length==0)
            return new int[0,0];

        int[,] newarray = new int[input.GetLength(1), input.GetLength(0)]; 

        for(int i=0; i<input.GetLength(1); i++)
        {
            for(int j=0; j<input.GetLength(0); j++)
            {
                newarray[i, j]=input[j, i];
            }
        }
        return newarray;  // 100 %
    }
}