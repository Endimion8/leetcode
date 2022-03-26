// https://leetcode.com/problems/search-a-2d-matrix/
// 74. Search a 2D Matrix
// Write an efficient algorithm that searches for a value target
// in an m x n integer matrix matrix. This matrix has the following properties:
//
// Integers in each row are sorted from left to right.
// The first integer of each row is greater than the last integer of the previous row.
// Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
// Output: true
// Сложность Log(m)*Log(n)

var input = new int[][] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } };
var input2 = new int[][] { new[] { 1 } };
var input3 = new int[][] { new int[] {}  };
// Console.WriteLine(Solution.MatrixBinarySearch(input, 3));
// Console.WriteLine(Solution.MatrixBinarySearch(input, 16));
// Console.WriteLine(Solution.MatrixBinarySearch(input, 65));
// Console.WriteLine(Solution.MatrixBinarySearch(input, 13));
Console.WriteLine(Solution.MatrixBinarySearch(input2, 1));
Console.WriteLine(Solution.MatrixBinarySearch(input3, 1));
Console.WriteLine(Solution.IntBinarySearch(new[] { 1 }, 1));

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var (x, y) = MatrixBinarySearch(matrix, target);
        return x >= 0 && y >= 0;
    }

    public static ValueTuple<int, int> MatrixBinarySearch(int[][] array, int key)
    {
        int left = 0;
        int right = array.Length - 1;
        int middle;

        while (left <= right)
        {
            middle = (left + right) / 2;
            var (resultIndex, direction) = IntBinarySearch(array[middle], key);
            if (resultIndex >= 0)
            {
                return (middle, resultIndex);
            }

            if (direction > 0)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return (-1, -1);
    }
    
    public static ValueTuple<int, int> IntBinarySearch(int[] array, int key)
    {
        int left = 0;
        int right = array.Length - 1;
        int middle;

        while (left <= right)
        {
            middle = (left + right) / 2;
            if (array[middle] == key)
            {
                return (middle, 0);
            }

            if (array[middle] < key)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return left == 0 ? (-1, -1) : (-1, 1);
    }
}