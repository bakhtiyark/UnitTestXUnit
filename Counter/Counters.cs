namespace Counter;

public class Counters
{
    private int CountConsecutive(string word, Func<char, char, bool> comparison)
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
            if (comparison(charArray[i], charArray[i - 1]))
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

    public int CountUnequalConsecutiveCharacters(string word)
    {
        return CountConsecutive(word, (current, previous) => current != previous);
    }

    public int CountEqualConsecutiveLatinCharacters(string word)
    {
        return CountConsecutive(word, (current, previous) => 
            char.IsLetter(current) && char.IsLetter(previous) &&
            char.ToLower(current) == char.ToLower(previous));
    }

    public int CountMaxConsecutiveNumbers(string word)
    {
        return CountConsecutive(word, (current, previous) =>
            char.IsDigit(current) && char.IsDigit(previous) && current == previous);
    }
}
