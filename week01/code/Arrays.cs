public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double start, int count)
    {
        // Plan for MultiplesOf:
        // 1. Create an array of size 'count'.
        // 2. Use a loop to fill the array with multiples of 'start'.
        //    - For each index i, the value should be start * (i + 1).
        // 3. Return the filled array.

        double[] result = new double[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = start * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan for RotateListRight:
        // 1. Find the split point: the last 'amount' elements will move to the front.
        // 2. Use GetRange to get the last 'amount' elements.
        // 3. Use GetRange to get the first part (everything except the last 'amount').
        // 4. Clear the original list.
        // 5. Add the last 'amount' elements first, then add the first part after.

        int split = data.Count - amount;
        List<int> end = data.GetRange(split, amount);
        List<int> start = data.GetRange(0, split);
        data.Clear();
        data.AddRange(end);
        data.AddRange(start);
    }
}
