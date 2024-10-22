using System.Collections.Generic;
using Xunit;

namespace Offline.Bootcamp.Tests;

public class Arrays
{
    private readonly Tasks.Arrays solutions = new();

    #region Problem 1: Max Value in Array

    /// <summary>
    /// Problem: Given an array of integers, find the maximum value.
    /// Write a method in the Solutions class named MaxValueInArray that takes an integer array
    /// as input and returns the maximum value in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 10, 7 }, 10)]
    [InlineData(new int[] { 100, 50, 20, 30 }, 100)]
    [InlineData(new int[] { -10, -5, -20, -100 }, -5)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, -5)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 5)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, int.MaxValue)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, int.MaxValue)]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, int.MinValue)]
    [InlineData(new int[] { 0, int.MinValue, int.MaxValue }, int.MaxValue)]
    public void TestMaxValueInArray(int[] array, int expected)
    {
        Assert.Equal(expected, this.solutions.MaxValueInArray(array));
    }

    #endregion

    #region Problem 2: Reverse Array

    /// <summary>
    /// Problem: Given an array of integers, reverse it in-place.
    /// Write a method in the Solutions class named ReverseArray that takes an integer array
    /// as input and reverses the elements in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 40, 30, 20, 10 }, new int[] { 10, 20, 30, 40 })]
    [InlineData(new int[] { -5, 10, 0, -20 }, new int[] { -20, 0, 10, -5 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 10 }, new int[] { 10 })]
    [InlineData(new int[] { -5, -10 }, new int[] { -10, -5 })]
    [InlineData(new int[] { int.MaxValue, int.MinValue }, new int[] { int.MinValue, int.MaxValue })]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, new int[] { int.MinValue, int.MinValue, int.MinValue })]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, new int[] { int.MaxValue, int.MaxValue, int.MaxValue })]
    public void TestReverseArray(int[] array, int[] expected)
    {
        Assert.Equal(expected, this.solutions.ReverseArray(array));
    }

    #endregion

    #region Problem 3: Check if Array is Sorted

    /// <summary>
    /// Problem: Given an array of integers, determine if it is sorted in non-decreasing order.
    /// Write a method in the Solutions class named IsArraySorted that takes an integer array
    /// as input and returns true if the array is sorted in non-decreasing order, otherwise false.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, true)]
    [InlineData(new int[] { 10, 20, 30, 20, 50 }, false)]
    [InlineData(new int[] { }, true)]
    [InlineData(new int[] { 10 }, true)]
    [InlineData(new int[] { -5, -5, -5, -5 }, true)]
    [InlineData(new int[] { -10, -5, 0, 5 }, true)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, true)]
    [InlineData(new int[] { int.MinValue, int.MaxValue, int.MinValue }, false)]
    public void TestIsArraySorted(int[] array, bool expected)
    {
        Assert.Equal(expected, this.solutions.IsArraySorted(array));
    }

    #endregion

    #region Problem 4: Sum of Even Numbers in Array

    /// <summary>
    /// Problem: Given an array of integers, find the sum of all even numbers.
    /// Write a method in the Solutions class named SumOfEvenNumbers that takes an integer array
    /// as input and returns the sum of all even numbers in the array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
    [InlineData(new int[] { 10, 20, 30, 40 }, 100)]
    [InlineData(new int[] { -10, -5, -20, -100 }, -130)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, 0)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 0)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, int.MinValue)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, 0)]
    [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue }, typeof(OverflowException))]
    [InlineData(new int[] { 0, int.MinValue, int.MaxValue }, int.MinValue)]
    [InlineData(new int[] { }, typeof(Exception))]
    [InlineData(null, typeof(Exception))]
    public void TestSumOfEvenNumbers(int[] array, object expected)
    {
        if (expected is int exp)
            Assert.Equal(exp, this.solutions.SumOfEvenNumbers(array));
        else if (expected is Type type && type.IsSubclassOf(typeof(Exception)))
            Assert.Throws(type, () => this.solutions.SumOfEvenNumbers(array));
    }

    #endregion

    #region Problem 5: Remove Duplicates from Sorted Array

    /// <summary>
    /// Problem: Given a sorted array of integers, remove duplicates in-place such that each element appears only once.
    /// Write a method in the Solutions class named RemoveDuplicates that takes a sorted integer array
    /// as input and modifies the array in-place to remove duplicates, returning the new length of the modified array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new int[] { }, new int[] { }, 0)]
    [InlineData(new int[] { -5, -5, -5, -5 }, new int[] { -5 }, 1)]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, new int[] { int.MaxValue }, 1)]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, new int[] { int.MinValue, int.MaxValue }, 2)]
    [InlineData(new int[] { -10, -5, 0, 5 }, new int[] { -10, -5, 0, 5 }, 4)]
    public void TestRemoveDuplicates(int[] array, int[] expectedArray, int expectedLength)
    {
        int length = this.solutions.RemoveDuplicates(array);
        Assert.Equal(expectedLength, length);
        for (int i = 0; i < length; i++)
        {
            Assert.Equal(expectedArray[i], array[i]);
        }
    }

    #endregion

    #region Problem 6: Rotate Array

    /// <summary>
    /// Problem: Given an array, rotate the array to the right by k steps, where k is non-negative.
    /// Write a method in the Solutions class named RotateArray that takes an integer array and an integer k
    /// as input and modifies the array in-place to rotate it to the right by k steps.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 3, 4, 5, 1, 2 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { 1 }, 0, new int[] { 1 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
    [InlineData(new int[] { -5, -5, -5, -5 }, 3, new int[] { -5, -5, -5, -5 })]
    [InlineData(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, 1, new int[] { int.MaxValue, int.MaxValue, int.MaxValue })]
    [InlineData(new int[] { int.MinValue, int.MaxValue }, 1, new int[] { int.MaxValue, int.MinValue })]
    public void TestRotateArray(int[] array, int k, int[] expected)
    {
        this.solutions.RotateArray(array, k);
        Assert.Equal(expected, array);
    }

    #endregion

    #region Problem 7: Merge Sorted Arrays

    /// <summary>
    /// Problem: Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    /// The number of elements initialized in nums1 and nums2 are m and n respectively.
    /// Write a method in the Solutions class named MergeSortedArrays that takes three parameters:
    /// integer array nums1 (with enough space to hold additional elements), integer m (the number of elements initialized in nums1),
    /// integer array nums2 (length is n), and integer n (the number of elements initialized in nums2).
    /// The method should merge nums2 into nums1 as one sorted array.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
    [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { -1, 0, 4 }, 3, new int[] { -1, 0, 1, 2, 3, 4 })]
    [InlineData(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { }, 0, new int[] { }, 0, new int[] { })]
    public void TestMergeSortedArrays(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        this.solutions.MergeSortedArrays(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    #endregion

    #region Problem 8: Find Missing Number

    /// <summary>
    /// Problem: Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
    /// Write a method in the Solutions class named FindMissingNumber that takes an integer array nums containing n distinct numbers
    /// as input and returns the missing number.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [InlineData(new int[] { 0 }, 1)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 9)]
    [InlineData(new int[] { 1, 0, 3, 2, 5, 6, 7, 9, 8 }, 4)]
    public void TestFindMissingNumber(int[] nums, int expected)
    {
        Assert.Equal(expected, this.solutions.FindMissingNumber(nums));
    }

    #endregion

    #region Problem 9: Find Peak Element

    /// <summary>
    /// Problem: A peak element in an array is an element that is strictly greater than its neighbors.
    /// Given an integer array nums, find a peak element, and return its index. If the array contains multiple peaks,
    /// return the index to any of the peaks. You may imagine that nums[-1] = nums[n] = -∞.
    /// Write a method in the Solutions class named FindPeakElement that takes an integer array nums
    /// as input and returns the index of any peak element.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 2)] // Peak is at index 2
    [InlineData(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)] // Peak is at index 5
    [InlineData(new int[] { 1, 2, 3 }, 2)] // Peak is at index 2
    [InlineData(new int[] { 1, 2, 1, 2, 1 }, 1)] // Peak is at index 1 or 3
    [InlineData(new int[] { 2, 1, 3 }, 2)] // Peak is at index 0 or 2
    public void TestFindPeakElement(int[] nums, int expected)
    {
        Assert.Equal(expected, this.solutions.FindPeakElement(nums));
    }

    #endregion

    #region Problem 10: Sort Array By Parity

    /// <summary>
    /// Problem: Given an array nums of non-negative integers, return an array consisting of all the even elements of nums,
    /// followed by all the odd elements of nums. You may return any answer array that satisfies this condition.
    /// Write a method in the Solutions class named SortArrayByParity that takes an integer array nums as input
    /// and returns the modified array with all even elements followed by all odd elements.
    /// </summary>
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 2, 4, 3, 1 })]
    [InlineData(new int[] { 0, 2, 1, 3 }, new int[] { 0, 2, 1, 3 })]
    [InlineData(new int[] { 2, 4, 6, 8 }, new int[] { 2, 4, 6, 8 })]
    [InlineData(new int[] { 1, 3, 5, 7 }, new int[] { 1, 3, 5, 7 })]
    [InlineData(new int[] { 2 }, new int[] { 2 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 4, 6, 1, 3, 5 })]
    public void TestSortArrayByParity(int[] nums, int[] expected)
    {
        Assert.Equal(expected, this.solutions.SortArrayByParity(nums));
    }



    #endregion

    #region Problem 11: Multi-dimensional Array Operations

    /// <summary>
    /// Problem: Given a 2D matrix, transpose it.
    /// Write a method in the Solutions class named TransposeMatrix that takes a 2D integer array
    /// as input and returns the transposed matrix.
    /// </summary>
    [Theory]
    [MemberData(nameof(TransposeMatrixData))]
    public void TestTransposeMatrix(int[,] input, int[,] expected) =>
        Assert.Equal(expected, this.solutions.TransposeMatrix(input));

    public static IEnumerable<object[]> TransposeMatrixData()
    {
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 1, 3 }, { 2, 4 } } };
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }, new int[,] { { 1, 4 }, { 2, 5 }, { 3, 6 } } };
        yield return new object[] { new int[,] { { 1 } }, new int[,] { { 1 } } };
        yield return new object[] { new int[,] { }, new int[,] { } };
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } } };
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new int[,] { { 1, 3, 5 }, { 2, 4, 6 } } };
        yield return new object[] { new int[,] { { 1, 2, 3, 4 } }, new int[,] { { 1 }, { 2 }, { 3 }, { 4 } } };
        yield return new object[] { new int[,] { { 1 }, { 2 }, { 3 }, { 4 } }, new int[,] { { 1, 2, 3, 4 } } };
        yield return new object[] { new int[,] { { 1, 0 }, { 0, 1 } }, new int[,] { { 1, 0 }, { 0, 1 } } };
        yield return new object[] { new int[,] { { int.MinValue, int.MaxValue }, { 0, 1 } }, new int[,] { { int.MinValue, 0 }, { int.MaxValue, 1 } } };
    }

    /// <summary>
    /// Problem: Given an N x N 2D matrix, rotate it 90 degrees clockwise.
    /// Write a method in the Solutions class named RotateMatrix90Degrees that takes a 2D integer array
    /// as input and returns the rotated matrix.
    /// </summary>
    [Theory]
    [MemberData(nameof(RotateMatrix90DegreesData))]
    public void TestRotateMatrix90Degrees(int[,] input, int[,] expected) =>
        Assert.Equal(expected, this.solutions.RotateMatrix90Degrees(input));

    public static IEnumerable<object[]> RotateMatrix90DegreesData()
    {
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } } };
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 3, 1 }, { 4, 2 } } };
        yield return new object[] { new int[,] { { 1 } }, new int[,] { { 1 } } };
        yield return new object[] { new int[,] { }, new int[,] { } };
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } }, new int[,] { { 5, 3, 1 }, { 6, 4, 2 } } };
        yield return new object[] { new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }, new int[,] { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } } };
        yield return new object[] { new int[,] { { 0 } }, new int[,] { { 0 } } };
        yield return new object[] { new int[,] { { 1, 0 }, { 0, 1 } }, new int[,] { { 0, 1 }, { 1, 0 } } };
        yield return new object[] { new int[,] { { int.MinValue, int.MaxValue }, { 0, 1 } }, new int[,] { { 0, int.MinValue }, { 1, int.MaxValue } } };
        yield return new object[] { new int[,] { { 1, 1 }, { 1, 1 } }, new int[,] { { 1, 1 }, { 1, 1 } } };
    }

    /// <summary>
    /// Problem: Find the largest element in a 2D matrix.
    /// Write a method in the Solutions class named FindLargestElementInMatrix that takes a 2D integer array
    /// as input and returns the largest element in the matrix.
    /// </summary>
    [Theory]
    [MemberData(nameof(FindLargestElementInMatrixData))]
    public void TestFindLargestElementInMatrix(int[,] input, int expected) =>
        Assert.Equal(expected, this.solutions.FindLargestElementInMatrix(input));

    public static IEnumerable<object[]> FindLargestElementInMatrixData()
    {
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, 9 };
        yield return new object[] { new int[,] { { -5, -2 }, { -9, -1 } }, -1 };
        yield return new object[] { new int[,] { { 1 } }, 1 };
        yield return new object[] { new int[,] { { int.MinValue, 0 }, { int.MaxValue, 100 } }, int.MaxValue };
        yield return new object[] { new int[,] { { 0, 0 }, { 0, 0 } }, 0 };
        yield return new object[] { new int[,] { { -1, -1 }, { -1, -1 } }, -1 };
        yield return new object[] { new int[,] { { 100, 200 }, { 300, 400 } }, 400 };
        yield return new object[] { new int[,] { { int.MinValue } }, int.MinValue };
        yield return new object[] { new int[,] { { 1, 2, 3, 4, 5 } }, 5 };
        yield return new object[] { new int[,] { { 1 }, { 2 }, { 3 }, { 4 }, { 5 } }, 5 };
    }

    /// <summary>
    /// Problem: Calculate the sum of diagonal elements in a square matrix.
    /// Write a method in the Solutions class named SumOfDiagonalElements that takes a 2D integer array
    /// as input and returns the sum of the diagonal elements.
    /// </summary>
    [Theory]
    [MemberData(nameof(SumOfDiagonalElementsData))]
    public void TestSumOfDiagonalElements(int[,] input, int expected) =>
        Assert.Equal(expected, this.solutions.SumOfDiagonalElements(input));

    public static IEnumerable<object[]> SumOfDiagonalElementsData()
    {
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, 15 };
        yield return new object[] { new int[,] { { 1, 0, 0 }, { 0, 2, 0 }, { 0, 0, 3 } }, 6 };
        yield return new object[] { new int[,] { { 1 } }, 1 };
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 } }, 5 };
        yield return new object[] { new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }, 34 };
        yield return new object[] { new int[,] { { 0, 0 }, { 0, 0 } }, 0 };
        yield return new object[] { new int[,] { { -1, -2 }, { -3, -4 } }, -5 };
        yield return new object[] { new int[,] { { int.MaxValue } }, int.MaxValue };
        yield return new object[] { new int[,] { { int.MinValue, 0 }, { 0, int.MaxValue } }, int.MinValue + int.MaxValue };
        yield return new object[] { new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, 3 };
    }

    /// <summary>
    /// Problem: Check if a given matrix is symmetric.
    /// Write a method in the Solutions class named IsSymmetricMatrix that takes a 2D integer array
    /// as input and returns true if the matrix is symmetric, false otherwise.
    /// </summary>
    [Theory]
    [MemberData(nameof(IsSymmetricMatrixData))]
    public void TestIsSymmetricMatrix(int[,] input, bool expected) =>
        Assert.Equal(expected, this.solutions.IsSymmetricMatrix(input));

    public static IEnumerable<object[]> IsSymmetricMatrixData()
    {
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } }, true };
        yield return new object[] { new int[,] { { 1, 2 }, { 3, 4 } }, false };
        yield return new object[] { new int[,] { { 1 } }, true };
        yield return new object[] { new int[,] { }, true };
        yield return new object[] { new int[,] { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 7 } }, true };
        yield return new object[] { new int[,] { { 0, 1 }, { 1, 0 } }, true };
        yield return new object[] { new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, true };
        yield return new object[] { new int[,] { { 1, 2, 3, 4 }, { 2, 1, 5, 6 }, { 3, 5, 1, 7 }, { 4, 6, 7, 1 } }, true };
        yield return new object[] { new int[,] { { int.MaxValue, 0 }, { 0, int.MinValue } }, true };
        yield return new object[] { new int[,] { { 1, 2 }, { 2, 1 }, { 3, 4 } }, false };
    }

    #endregion

    #region Problem 12: Jagged Array Operations

    /// <summary>
    /// Problem: Flatten a jagged array into a 1D array.
    /// Write a method in the Solutions class named FlattenJaggedArray that takes a jagged integer array
    /// as input and returns a flattened 1D array.
    /// </summary>
    [Theory]
    [MemberData(nameof(FlattenJaggedArrayData))]
    public void TestFlattenJaggedArray(int[][] input, int[] expected) =>
        Assert.Equal(expected, this.solutions.FlattenJaggedArray(input));

    public static IEnumerable<object[]> FlattenJaggedArrayData()
    {
        yield return new object[] { new[] { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6 } }, new[] { 1, 2, 3, 4, 5, 6 } };
        yield return new object[] { new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, new[] { 1, 2, 3 } };
        yield return new object[] { new int[][] { }, new int[] { } };
        yield return new object[] { new[] { new int[] { }, new int[] { } }, new int[] { } };
        yield return new object[] { new[] { new[] { 1 } }, new[] { 1 } };
        yield return new object[] { new[] { new[] { 1, 2, 3 }, new[] { 4, 5 }, new[] { 6, 7, 8, 9 } }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
        yield return new object[] { new[] { new[] { -1, -2 }, new[] { 0 }, new[] { 1, 2 } }, new[] { -1, -2, 0, 1, 2 } };
        yield return new object[] { new[] { new[] { int.MinValue }, new[] { int.MaxValue } }, new[] { int.MinValue, int.MaxValue } };
        yield return new object[] { new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } }, new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 } };
        yield return new object[] { new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
    }

    /// <summary>
    /// Problem: Find the maximum element in a jagged array.
    /// Write a method in the Solutions class named FindMaxInJaggedArray that takes a jagged integer array
    /// as input and returns the maximum element in the array.
    /// </summary>
    [Theory]
    [MemberData(nameof(FindMaxInJaggedArrayData))]
    public void TestFindMaxInJaggedArray(int[][] input, int expected) =>
        Assert.Equal(expected, this.solutions.FindMaxInJaggedArray(input));

    public static IEnumerable<object[]> FindMaxInJaggedArrayData()
    {
        yield return new object[] { new[] { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6 } }, 6 };
        yield return new object[] { new[] { new[] { -1, -2 }, new[] { -3, -4 } }, -1 };
        yield return new object[] { new[] { new[] { int.MinValue }, new[] { 0, int.MaxValue } }, int.MaxValue };
        yield return new object[] { new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, 3 };
        yield return new object[] { new[] { new[] { 100, 200 }, new[] { 300 }, new[] { 400, 500 } }, 500 };
        yield return new object[] { new[] { new[] { 0, 0 }, new[] { 0 }, new[] { 0, 0, 0 } }, 0 };
        yield return new object[] { new[] { new[] { -100, -200 }, new[] { -300 }, new[] { -400, -500 } }, -100 };
        yield return new object[] { new[] { new[] { 1, 1, 1 }, new[] { 1, 1 }, new[] { 1 } }, 1 };
        yield return new object[] { new[] { new[] { int.MinValue, int.MaxValue }, new[] { 0 } }, int.MaxValue };
        yield return new object[] { new[] { new[] { 10 }, new[] { 100 }, new[] { 1000 }, new[] { 10000 } }, 10000 };
    }

    /// <summary>
    /// Problem: Calculate the sum of all elements in a jagged array.
    /// Write a method in the Solutions class named SumOfJaggedArray that takes a jagged integer array
    /// as input and returns the sum of all elements in the array.
    /// </summary>
    [Theory]
    [MemberData(nameof(SumOfJaggedArrayData))]
    public void TestSumOfJaggedArray(int[][] input, int expected) =>
        Assert.Equal(expected, this.solutions.SumOfJaggedArray(input));

    public static IEnumerable<object[]> SumOfJaggedArrayData()
    {
        yield return new object[] { new[] { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6 } }, 21 };
        yield return new object[] { new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, 6 };
        yield return new object[] { new int[][] { }, 0 };
        yield return new object[] { new[] { new int[] { }, new int[] { } }, 0 };
        yield return new object[] { new[] { new[] { -1, 2 }, new[] { -2 } }, -1 };
        yield return new object[] { new[] { new[] { 100, 200 }, new[] { 300 }, new[] { 400, 500 } }, 1500 };
        yield return new object[] { new[] { new[] { 0, 0 }, new[] { 0 }, new[] { 0, 0, 0 } }, 0 };
        yield return new object[] { new[] { new[] { -100, -200 }, new[] { -300 }, new[] { -400, -500 } }, -1500 };
        yield return new object[] { new[] { new[] { 1, 1, 1 }, new[] { 1, 1 }, new[] { 1 } }, 6 };
        yield return new object[] { new[] { new[] { int.MaxValue, int.MinValue }, new[] { 0 } }, -1 };
    }

    /// <summary>
    /// Problem: Calculate the average of all elements in a jagged array.
    /// Write a method in the Solutions class named AverageOfJaggedArray that takes a jagged integer array
    /// as input and returns the average of all elements in the array.
    /// </summary>
    [Theory]
    [MemberData(nameof(AverageOfJaggedArrayData))]
    public void TestAverageOfJaggedArray(int[][] input, double expected) =>
        Assert.Equal(expected, this.solutions.AverageOfJaggedArray(input), 6);

    public static IEnumerable<object[]> AverageOfJaggedArrayData()
    {
        yield return new object[] { new[] { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6 } }, 3.5 };
        yield return new object[] { new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, 2.0 };
        yield return new object[] { new[] { new[] { -1, 1 } }, 0.0 };
        yield return new object[] { new[] { new[] { 0, 0 }, new[] { 0 }, new[] { 0, 0, 0 } }, 0.0 };
        yield return new object[] { new[] { new[] { 100, 200 }, new[] { 300 }, new[] { 400, 500 } }, 300.0 };
        yield return new object[] { new[] { new[] { -10, -20 }, new[] { -30 }, new[] { -40, -50 } }, -30.0 };
        yield return new object[] { new[] { new[] { 1, 1, 1 }, new[] { 1, 1 }, new[] { 1 } }, 1.0 };
        yield return new object[] { new[] { new[] { int.MaxValue, int.MinValue }, new[] { 0 } }, -0.3333333333333333 };
        yield return new object[] { new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } }, 5.5 };
        yield return new object[] { new[] { new[] { -5, 5 }, new[] { -10, 10 }, new[] { -15, 15 } }, 0.0 };
    }

    /// <summary>
    /// Problem: Convert a jagged array to a string representation.
    /// Write a method in the Solutions class named JaggedArrayToString that takes a jagged integer array
    /// as input and returns a string representation of the array.
    /// </summary>
    [Theory]
    [MemberData(nameof(JaggedArrayToStringData))]
    public void TestJaggedArrayToString(int[][] input, string expected) =>
        Assert.Equal(expected, this.solutions.JaggedArrayToString(input));

    public static IEnumerable<object[]> JaggedArrayToStringData()
    {
        yield return new object[] { new[] { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6 } }, "[[1,2],[3,4,5],[6]]" };
        yield return new object[] { new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, "[[1],[2],[3]]" };
        yield return new object[] { new int[][] { }, "[]" };
        yield return new object[] { new[] { new int[] { }, new int[] { } }, "[[],[]]" };
        yield return new object[] { new[] { new[] { 1, 2, 3 } }, "[[1,2,3]]" };
        yield return new object[] { new[] { new[] { -1, -2 }, new[] { 0 }, new[] { 1, 2 } }, "[[-1,-2],[0],[1,2]]" };
        yield return new object[] { new[] { new[] { int.MinValue }, new[] { int.MaxValue } }, "[[" + int.MinValue + "],[" + int.MaxValue + "]]" };
        yield return new object[] { new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } }, "[[1,1,1],[2,2,2],[3,3,3]]" };
        yield return new object[] { new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } }, "[[1,2,3,4,5,6,7,8,9,10]]" };
        yield return new object[] { new[] { new[] { 0 }, new[] { 0, 0 }, new[] { 0, 0, 0 } }, "[[0],[0,0],[0,0,0]]" };
    }

    #endregion
}