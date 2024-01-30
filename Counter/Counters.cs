namespace Counter;

public class Counters
{
    /*
    Modify the application from the first task of the Basic of .NET framework and C # by separating the functionality
    of counting the maximum number of unequal consecutive characters in a string into a separate method. Extend
    functionality by adding two more methods:
     * determining the maximum number of consecutive identical letters of the Latin alphabet in a line
     * determining the maximum number of consecutive identical digits

    For each method, write Unit Tests (use the NUnit, XUnit or MSTest framework is your choice; follow AAA and FIRST).
    When creating tests, pay special attention to equivalence classes.
     */

    public int CountUnequalConsecutiveCharacters(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;
        char[] charArray = word.ToCharArray();

        for (int i = 1; i < charArray.Length; i++)
        {
            if (charArray[i] != charArray[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    public int CountEqualConsecutiveLatinCharacters(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;
        char[] charArray = word.ToCharArray();

        for (int i = 1; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]) && char.IsLetter(charArray[i - 1]) &&
                char.ToLower(charArray[i]) == char.ToLower(charArray[i - 1]))
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    public int CountMaxConsecutiveNumbers(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;
        char[] charArray = word.ToCharArray();

        for (int i = 1; i < charArray.Length; i++)
        {
            if (char.IsDigit(charArray[i]) && char.IsDigit(charArray[i - 1]) && charArray[i] == charArray[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }
}