using System;
class SP {
    static bool Sumpair(int[] A, int sum)
    {
        // Sort the input array in ascending order
        Array.Sort(A);
        
        // Initialize two pointers, one at the beginning (left) and one at the end (right) of the sorted array
        int left = 0;
        int right = A.Length - 1;

        // Loop while the left pointer is less than the right pointer
        while (left < right) {
            // Calculate the sum of elements at the current positions
            int currentSum = A[left] + A[right];

            // If the current sum equals the target sum, return true (a pair is found)
            if (currentSum == sum)
                return true;
            // If the current sum is less than the target sum, move the left pointer to the right (increase the sum)
            else if (currentSum < sum)
                left++;
            // If the current sum is greater than the target sum, move the right pointer to the left (decrease the sum)
            else
                right--;
        }

        // If the loop completes without finding a pair, return false (no pair is found)
        return false;
    }

    public static void Main()
    {
        int[] A = { 1, 4, 45, 6, 10, -8 };
        int n = 5;

        // Check if there is a pair of elements in the array that sums up to the target value (n)
        if (Sumpair(A, n))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
