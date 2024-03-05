namespace API.Interfaces;

public interface IRansomNoteManager
{
    bool CanConstructRansomNote(string ransomNote, string magazine);
}
