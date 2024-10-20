namespace Offline.Bootcamp.Tasks;

public class Arrays
{
    public double AverageOfJaggedArray(int[][] input)       //HAMMASI TO'G'RI
    {
        // Agar kirish jagged massiv null yoki bo'sh bo'lsa, 0.0 qaytarish
        if (input == null || input.Length == 0)
        {
            return 0.0;
        }

        // Yig'indi va umumiy elementlar soni uchun o'zgaruvchilar
        long sum = 0;
        int count = 0;

        // Har bir kichik massivni iteratsiya qilish
        for (int i = 0; i < input.Length; i++)
        {
            // Har bir kichik massivdagi elementlarni iteratsiya qilish
            for (int j = 0; j < input[i].Length; j++)
            {
                // Yig'indiga elementni qo'shish
                sum += input[i][j];
                // Elementlar sonini oshirish
                count++;
            }
        }
        return count == 0 ? 0.0 : (double)sum / count;
        throw new NotImplementedException();
    }

    //=============================================================================================
    public int FindLargestElementInMatrix(int[,] input)    // HAMMASI TO'G'RI
    {
        // Agar matrisaning uzunligi 0 bo'lsa, unda int.MinValue qaytaramiz
        if (input == null || input.Length == 0)
        {
            return int.MinValue;
        }

        // Dastlabki eng katta qiymatni input[0, 0] bilan boshlaymiz
        int max = input[0, 0];

        // Matrisaning o'lchamlarini aniqlash
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        // Matrisadagi barcha elementlarni tekshirish
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (input[i, j] > max)
                {
                    max = input[i, j];
                }
            }
        }

        // Eng katta elementni qaytarish
        return max;
        throw new NotImplementedException();
    }

    //==============================================================================================
    public int FindMaxInJaggedArray(int[][] input)   // HAMMASI TO'G'RI
    {
        // Agar kirish jagged massiv null yoki bo'sh bo'lsa, xatolikni tashlash
        if (input == null || input.Length == 0)
        {
            throw new ArgumentException("Input array is null or empty");
        }

        // Dastlabki maksimal qiymatni saqlash uchun o'zgaruvchi
        // Buning uchun dastlab birinchi mavjud elementni maksimal qiymat deb olamiz
        int max = int.MinValue;
        bool foundAnyElement = false; // Massivda kamida bitta element borligini tekshirish uchun

        // Har bir kichik massivni iteratsiya qilish
        for (int i = 0; i < input.Length; i++)
        {
            // Har bir kichik massivdagi elementlarni iteratsiya qilish
            for (int j = 0; j < input[i].Length; j++)
            {
                // Element mavjud bo'lsa, dastlabki qiymatni o'rnatish
                if (!foundAnyElement)
                {
                    max = input[i][j];
                    foundAnyElement = true;
                }

                // Joriy elementni maksimal qiymat bilan taqqoslash
                if (input[i][j] > max)
                {
                    max = input[i][j];
                }
            }
        }

        // Agar hech qanday element topilmagan bo'lsa, xatolikni tashlash
        if (!foundAnyElement)
        {
            throw new ArgumentException("Input array is empty or contains only empty sub-arrays");
        }

        // Eng katta elementni qaytarish
        return max;
        throw new NotImplementedException();
    }

    //===============================================================================================
    public int FindMissingNumber(int[] nums)   // HAMMASI TO'G'RI
    {
        int n = nums.Length; // Massiv uzunligini olish
        int expectedSum = (n * (n + 1)) / 2; // 0 dan n gacha bo'lgan sonlarning summasi
        int actualSum = 0; // Berilgan massivdagi sonlar summasi

        // Berilgan massivdagi sonlar summasini hisoblash
        for (int i = 0; i < n; i++)
        {
            actualSum += nums[i];
        }

        // Yo'qolgan sonni hisoblash
        return expectedSum - actualSum;
        throw new NotImplementedException();
    }

    //=================================================================================================
    public int FindPeakElement(int[] nums)  // HAMMASI TO'G'RI
    {
         int n = nums.Length;

        if (nums[0] > nums[1] || n == 1) 
        {
            return 0; 
        }
        if (nums[n - 1] > nums[n - 2]) 
        {
            return n - 1; 
        }
        for (int i = 1; i < n - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                return i; 
            }
        }
        throw new NotImplementedException();
    }

    //==============================================================================================
    public int[] FlattenJaggedArray(int[][] input)   // HAMMASI TO'G'RI
    {
         // Agar kirish jagged massiv null bo'lsa, bo'sh massiv qaytarish
        if (input == null)
        {
            return new int[] { };
        }

        // Umumiy elementlar sonini hisoblash
        int totalLength = 0;
        for (int i = 0; i < input.Length; i++)
        {
            totalLength += input[i].Length;
        }

        // Yangi bir o'lchovli massiv yaratish
        int[] flattenedArray = new int[totalLength];
        int index = 0;

        // Har bir kichik massivni iteratsiya qilish
        for (int i = 0; i < input.Length; i++)
        {
            // Har bir kichik massivdagi elementlarni iteratsiya qilish
            for (int j = 0; j < input[i].Length; j++)
            {
                // Elementni yangi massivga qo'shish
                flattenedArray[index++] = input[i][j];
            }
        }

        // Bir o'lchovli massivni qaytarish
        return flattenedArray;
        throw new NotImplementedException();
    }

    //================================================================================================
    public bool IsArraySorted(int[] array)     //HAMMASI TO'G'RI
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false; 
            }
        }
        return true;
        throw new NotImplementedException();
    }

    //=================================================================================================
    public bool IsSymmetricMatrix(int[,] input)    // HAMMASI TO'G'RI, 1TA O'ZGARISH
    {
        // Agar matrisa null bo'lsa yoki elementga ega bo'lmasa, simmetrik deb hisoblanadi
        if (input == null || input.Length == 0)
        {
            return true;
        }

        // Matrisaning o'lchamlarini aniqlash
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);

        // Kvadrat bo'lmagan matrisalar simmetrik bo'lishi mumkin emas
        if (rows != cols)
        {
            return false;
        }

        // Matrisaning har bir elementi bo'yicha tekshirish
        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                // Agar input[i, j] != input[j, i] bo'lsa, matrisalar simmetrik emas
                if (input[i, j] != input[j, i])
                {
                    return false;
                }
            }
        }

        // Agar barcha tekshirishlar muvaffaqiyatli o'tgan bo'lsa, matrisalar simmetrik
        return true;
        throw new NotImplementedException();
    }


    //==================================================================================================
    public string JaggedArrayToString(int[][] input)    // HAMMASI TO'G'RI
    {
        // Agar kirish jagged massiv null yoki bo'sh bo'lsa, "[]" qaytarish
        if (input == null || input.Length == 0)
        {
            return "[]";
        }

        // Natija qatorini hosil qilish uchun qatorni boshlash
        string result = "[";

        // Har bir kichik massivni iteratsiya qilish
        for (int i = 0; i < input.Length; i++)
        {
            // Kichik massivni qo'shish
            result += "[";

            // Har bir elementni kichik massivda iteratsiya qilish
            for (int j = 0; j < input[i].Length; j++)
            {
                // Elementni qo'shish
                result += input[i][j];

                // Agar element oxirgi bo'lmasa, vergul qo'shish
                if (j < input[i].Length - 1)
                {
                    result += ",";
                }
            }

            // Kichik massivni yopish
            result += "]";

            // Agar kichik massiv oxirgisi bo'lmasa, vergul qo'shish
            if (i < input.Length - 1)
            {
                result += ",";
            }
        }

        // Yopuvchi qavsni qo'shish
        result += "]";

        // Natijani qaytarish
        return result;
        
        throw new NotImplementedException();
    }

    //===================================================================================================
    public int MaxValueInArray(int[] array)    // HAMMASI TO'G'RI
    {
        var value = array[0];
        foreach(var i in array)
        {
            if(i > value)
            {
                value = i;
            }
        }
        return value;
        throw new NotImplementedException();
    }

    //====================================================================================================
    public int[] MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)   // HAMMASI TO'G'RI
    {
        int i = m - 1; // nums1 ning oxirgi elementi
        int j = n - 1; // nums2 ning oxirgi elementi
        int k = m + n - 1; // Yangi massivning oxirgi pozitsiyasi

        // nums1 va nums2 ni birlashtirish
        while (i >= 0 && j >= 0)
        {
            // Katta elementni qo'shish
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

        // Agar nums2 da qoldiqlar bo'lsa, ularni nums1 ga qo'shamiz
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
        return nums1;
        throw new NotImplementedException();
    }

    //=============================================================================================
    public int RemoveDuplicates(int[] array)     // HAMMASI TO'G'RI
    {
        int index = 0;
        if (array == null || array.Length == 0)
        {
            return 0;
        }
        else
        {
            for (int i = 1; i < array.Length; i++) 
            {
                if (array[index] != array[i]) 
                {
                    index++;
                    array[index] = array[i]; 
                }
            }

            return index + 1;
        }
        throw new NotImplementedException();
    }

    //===============================================================================================
    public int[] ReverseArray(int[] array)    // HAMMASI TO'G'RI
    {
        int[] reverseArray = new int[array.Length];
        
        for(int i = 0; i < array.Length; i++)
        {
            reverseArray[i] = array[array.Length-1-i];
        }
        return reverseArray;
        throw new NotImplementedException();
    }

    //=================================================================================================
    public int[] RotateArray(int[] array, int k)   // HAMMASI TO'G'RI
    {    
        if (array == null || array.Length == 0)
        {
            return array;
        }
        k %= array.Length; 

        int[] rotatedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            rotatedArray[(i + k) % array.Length] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rotatedArray[i];
        }     
        return array;                       
        
        throw new NotImplementedException();
    }

    //============================================================================================
    public int[,] RotateMatrix90Degrees(int[,] input)   // HAMMASI TO'G'RI
    {
        if (input == null || input.GetLength(0) == 0)
        {
            return new int[0, 0];
        }

        int n = input.GetLength(0); 
        int m = input.GetLength(1);
        int[,] rotated = new int[m, n]; 

        if (m == n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[j, n - 1 - i] = input[i, j];
                }
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rotated[j, n - 1 - i] = input[i, j];
                }
            }
        }

        return rotated;
        throw new NotImplementedException();
    }

    //==============================================================================================
    public int[] SortArrayByParity(int[] nums)    // HAMMASI TO'G'RI
    {
        if (nums == null || nums.Length == 0)
        {
            return nums;
        }

        int[] result = new int[nums.Length];
        int evenIndex = 0;
        int oddIndex = nums.Length - 1;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                result[evenIndex++] = nums[i];
            }
        }
        for(int j = nums.Length-1; j >= 0; j--)
        {    
            if(nums[j] % 2 != 0)
            {
                result[oddIndex--] = nums[j];
            }
        }

        return result;
        throw new NotImplementedException();
    }

    //=============================================================================================
    public int SumOfDiagonalElements(int[,] input)    //HAMMASI TO'G'RI
    {
        if (input == null || input.Length == 0)
        {
            return 0;
        }

        int size = input.GetLength(0);
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += input[i, i];
        }

        return sum;
        throw new NotImplementedException();
    }

    //===============================================================================================
    public int SumOfEvenNumbers(int[] array)      //  HAMMASI TO'G'RI
    {
        long x = 0;
        if (array == null || array.Length == 0)
        {
            throw new ArgumentNullException(nameof(array));
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                x += array[i];
            }
        }
       if(int.MaxValue < x || int.MinValue > x)
        {
            throw new OverflowException();
        }
       return (int)x;
        
    }

    //=========================================================================================
    public int SumOfJaggedArray(int[][] input)   //HAMMASI TO'G'RI
    {
        if (input == null || input.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                sum += input[i][j];
            }
        }

        return sum;
        throw new NotImplementedException();
    }

    //==========================================================================================
    public int[,] TransposeMatrix(int[,] input)    //HAMMASI TO'G'RI
    {
        if (input == null || input.GetLength(0) == 0)
        {
            return new int[0, 0];
        }

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
        throw new NotImplementedException();
    }
}