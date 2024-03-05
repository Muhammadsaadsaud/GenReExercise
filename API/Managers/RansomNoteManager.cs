using API.Interfaces;

namespace API.Managers;

// RansomNoteManager implements the IRansomNoteManager interface.
public class RansomNoteManager : IRansomNoteManager
{
    // Determines whether a ransom note can be constructed from a given magazine.
    public bool CanConstructRansomNote(string ransomNote, string magazine)
    {
        // Check if either ransomNote or magazine is null or empty.
        if (string.IsNullOrEmpty(ransomNote) || string.IsNullOrEmpty(magazine))
        {
            throw new ArgumentException("Ransom note and magazine cannot be null or empty.");
        }

        // Dictionary to store the count of each character in the magazine.
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count characters in magazine.
        foreach (char c in magazine)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Check ransom note.
        foreach (char c in ransomNote)
        {
            // If the character is not present in the magazine or its count is zero,
            // it cannot be used to construct the ransom note.
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
            {
                return false;
            }
            charCount[c]--; // Decrement the count of the character in the magazine.
        }

        // If the method completes the iteration without returning false,
        // it means the ransom note can be constructed, so return true.
        return true;
    }
}
