using API.Controllers;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace UnitTest;

[TestFixture]
public class RansomNoteControllerTests
{
    private RansomNoteController _ransomNoteController;
    private Mock<IRansomNoteManager> _mockRansomNoteManager;

    [SetUp]
    public void Setup()
    {
        _mockRansomNoteManager = new Mock<IRansomNoteManager>();
        _ransomNoteController = new RansomNoteController(_mockRansomNoteManager.Object);
    }

    [Test]
    public void CanConstruct_ShouldReturnTrue()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "aab";
        _mockRansomNoteManager.Setup(x => x.CanConstructRansomNote(ransomNote, magazine)).Returns(true);

        // Act
        ActionResult<bool> result = _ransomNoteController.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.IsTrue(result.Value);
    }

    [Test]
    public void CanConstruct_ShouldReturnFalse()
    {
        // Arrange
        string ransomNote = "aa";
        string magazine = "ab";
        _mockRansomNoteManager.Setup(x => x.CanConstructRansomNote(ransomNote, magazine)).Returns(false);

        // Act
        ActionResult<bool> result = _ransomNoteController.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.IsFalse(result.Value);
    }
}

