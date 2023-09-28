using System;

namespace BoxOfCoins
{
    // Class to represent a box of coins
    public class CoinBox
    {
        // Property to store the array of coin values in the box
        public int[] Boxes { get; private set; }

         // Constructor to initialize the CoinBox with an array of coin values
        public CoinBox(int[] boxes)
        {
            Boxes = boxes;
        }

        // Calculate the maximum value difference between Alex and Cindy
        public int Solve()
        {
            // Calculating the total sum of values in all boxes
            int sum = Sum(Boxes);

            // Calculating the maximum value that Alex can obtain
            int alexValue = AlexMaxCoins(Boxes);

            // Calculating the value that Cindy will get
            int cindyValue = sum - alexValue;

            // Returning the difference between Alex's and Cindy's values
            return alexValue - cindyValue;
        }

        // Calculating the sum of values in an array of boxes
        private static int Sum(int[] boxes)
        {
            int sum = 0;
            foreach (int item in boxes)
            {
                sum += item;
            }
            return sum;
        }

        // Calculating the maximum value that Alex can obtain using dynamic programming
        private static int AlexMaxCoins(int[] boxes)
        {
            int n = boxes.Length;
            int[,] dp = new int[n, n]; // Create a dynamic programming table

            // Iterating over all possible subarray lengths
            for (int len = 1; len <= n; len++)
            {
                // Iterating over all possible subarray positions
                for (int i = 0; i <= n - len; i++)
                {
                    int j = i + len - 1; // Calculate the end index of the subarray

                    // Calculating values for x, y, and z based on dynamic programming rules
                    int x = ((i + 2) <= j) ? dp[i + 2, j] : 0;
                    int y = ((i + 1) <= (j - 1)) ? dp[i + 1, j - 1] : 0;
                    int z = (i <= (j - 2)) ? dp[i, j - 2] : 0;

                    // Calculating the maximum value for the current subarray and updating dp table
                    dp[i, j] = Math.Max(boxes[i] + Math.Min(x, y), boxes[j] + Math.Min(y, z));
                }
            }

            // The result is stored in dp[0, n - 1], which represents the maximum value for Alex
            return dp[0, n - 1];
        }
    }
}
