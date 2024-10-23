
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
    // 1 dan N gacha bo'lgan sonlar ketma-ketligi uchun N ni hisoblash
    int n = nums.Length; // N - berilgan sonlar soni

    // Asl yig'indini hisoblash: 1 dan N gacha bo'lgan sonlar yig'indisi
    int expectedSum = (n * (n + 1)) / 2;

    // Berilgan sonlarning amaldagi yig'indisini hisoblash
    int actualSum = 0;
    foreach (int num in nums)
    {
        actualSum += num; // Har bir sonni yig'indiga qo'shish
    }

    // Qoldirilgan sonni aniqlash
    return expectedSum - actualSum;   
     }

    public int FindPeakElement(int[] nums)
    {  
        var max = nums[0];
        foreach(var item in nums)
        {
            if(item >max)
            {
                max = item;
            }
        }
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] == max)
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
 // An empty array or an array with one element is considered sorted.  
       if (array.Length <=1)  
       {  
       return true;  
       }  
      
       for (int i =0; i < array.Length -1; i++)  
       {  
       if (array[i] > array[i +1]) // Check if current element is greater than the next element.  
       {  
       return false; // If true, the array is not sorted.  
       }  
       }  

 return true; // If all elements are in non-decreasing order, return true.  
    }

public bool IsSymmetricMatrix(int[,] input)
{
    if (input == null)
    {
        throw new ArgumentNullException(nameof(input), "Input cannot be null.");
    }

    int rows = input.GetLength(0);
    int cols = input.GetLength(1);

    // Bo'sh matritsa simmetrik
    if (rows == 0 && cols == 0)
        return true;

    // Matritsa kvadrat bo'lishi kerak
    if (rows != cols)
        return false;

    for (var i = 0; i < rows; i++)
    {
        for (var j = i + 1; j < cols; j++) // j ni i + 1 dan boshlash
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
        foreach(var i in array)
            if(i > max)
                max = i;

        return max;
    }

    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
    {
    // Indekslar: nums1 va nums2 ning oxiridan boshlab
    int i = m - 1; // nums1 ning haqiqiy elementlari
    int j = n - 1; // nums2 ning elementlari
    int k = m + n - 1; // nums1 ning umumiy uzunligi

    // Har ikkala massivni tahlil qilish
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

    // Agar nums2 dan qolgan elementlar mavjud bo'lsa, ularni nusxalash
    while (j >= 0)
    {
        nums1[k] = nums2[j];
        j--;
        k--;
    }
        }

    public int RemoveDuplicates(int[] array)
    {
    // Agar massiv bo'sh bo'lsa yoki faqat bitta element bo'lsa, uni qaytarish
    if (array.Length == 0)
        return 0;

    // Ko'rsatkichni boshlaymiz (qoldiriladigan dublikatsiz elementlar uchun)
    int uniqueIndex = 0;

    // Massivdagi barcha elementlarni 2-elementdan boshlab tekshiramiz
    for (int i = 1; i < array.Length; i++)
    {
        // Agar joriy element oldingi elementdan farqli bo'lsa, biz uni yangi joyiga ko'chiramiz
        if (array[i] != array[uniqueIndex])
        {
            uniqueIndex++;
            array[uniqueIndex] = array[i];
        }
    }

    // Dublikat bo'lmagan elementlar soni qaytariladi (uniqueIndex + 1, chunki indeks 0-dan boshlanadi)
    return uniqueIndex + 1;
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

    // Juft raqamlarni birinchi joyga qo'yish
    evenNumbers.AddRange(oddNumbers);

    return evenNumbers.ToArray();
}


public int SumOfDiagonalElements(int[,] input)
{
    var sum = 0; // Sumni nolga tenglash
    for (var i = 0; i < input.GetLength(0); i++)
    {
        sum += input[i, i]; // Diagonal elementlarni qo'shish
    }

    return sum; // Natijani qaytarish
}


public int SumOfEvenNumbers(int[]? array)
{
    if (array is null || array.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    long sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += array[i];
        }
    }

    if (sum < int.MinValue || sum > int.MaxValue)
    {
        throw new OverflowException("Sum exceeds the range of an integer.");
    }

    return (int)sum;
}


public int SumOfJaggedArray(int[][] input)
{
    if (input == null) // Null tekshiruvi
    {
        throw new ArgumentNullException(nameof(input), "Input cannot be null.");
    }

    var sum = 0;

    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] == null) // Har bir ichki massivning null tekshiruvi
        {
            continue; // Agar ichki massiv null bo'lsa, o'tkazib yuborish
        }

        for (var j = 0; j < input[i].Length; j++)
        {
            sum += input[i][j];
        }
    }

    return sum;
}


 public int[,] TransposeMatrix(int[,] input)
{
    if (input == null)
    {
        throw new ArgumentNullException(nameof(input), "Input cannot be null.");
    }

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