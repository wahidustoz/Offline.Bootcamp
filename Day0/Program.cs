bool IsSymmetricMatrix(int[,] input)
{
    // Step 1: Ensure matrix is square
    if (input.GetLength(0) != input.GetLength(1))
    {
        return false; // Not a square matrix, can't be symmetric
    }

    // Step 2: Check for symmetry by comparing elements across the diagonal
    int size = input.GetLength(0); // Number of rows (or columns, since it's square)
    for (var i = 0; i < size; i++)
    {
        for (var j = i + 1; j < size; j++) // Start j from i+1 to avoid redundant checks
        {
            // Compare element (i, j) with element (j, i)
            Console.WriteLine($"{input[j, i]} != {input[i, j]}");

            if (input[j, i] != input[i, j])
            {
                Console.WriteLine($"{input[j, i]} != {input[i, j]}");
                return false; // If mismatch, it's not symmetric
            }
        }
    }
    
    return true; // All elements matched, it's symmetric
}

var myInt = new int[,] {{ 1, 2, 3 }, 
                                                { 2, 4, 5 }, 
                                                { 3, 5, 7 } };

var sum = IsSymmetricMatrix(myInt);

Console.WriteLine(sum);

/*for (var i = 0; i < sum.GetLength(0); i++)
{
    for (var j = 0; j < sum.GetLength(1); j++)
    {
        Console.Write(sum[i, j] + " ");
    }
    Console.WriteLine();
}*/


