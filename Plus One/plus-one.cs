public int[] PlusOne(int[] digits)
{
    int n = digits.Length;
    
    // Traverse the array from the last digit backwards
    for (int i = n - 1; i >= 0; i--)
    {
        // If current digit is less than 9, just increment and return
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        // Set current digit to 0 if it's 9
        digits[i] = 0;
    }
    
    // If all digits were 9, the result is 100...0, so we need an extra digit at the front
    int[] result = new int[n + 1];
    result[0] = 1;  // The rest are 0 by default
    return result;
}