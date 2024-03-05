using NUnit.Framework;
using API.Managers;

namespace UnitTest;

[TestFixture]
public class RansomNoteManagerTests
{
    private RansomNoteManager _ransomNoteManager;

    [SetUp]
    public void Setup()
    {
        _ransomNoteManager = new RansomNoteManager();
    }

    [Test]
    public void CanConstructRansomNote_ShouldReturnTrue()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "aab";

        // Act
        bool result = _ransomNoteManager.CanConstructRansomNote(ransomNote, magazine);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CanConstructRansomNote_ShouldReturnFalse()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "ab";

        // Act
        bool result = _ransomNoteManager.CanConstructRansomNote(ransomNote, magazine);

        // Assert
        Assert.IsFalse(result);
    }
}

