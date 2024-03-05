using API.Controllers;
using API.Interfaces;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace UnitTest;

[TestFixture]
public class BinarySearchTreeControllerTests
{
    private BinarySearchTreeController _binarySearchTreeController;
    private Mock<IBinarySearchTreeManager> _mockBinarySearchTreeManager;

    [SetUp]
    public void Setup()
    {
        _mockBinarySearchTreeManager = new Mock<IBinarySearchTreeManager>();
        _binarySearchTreeController = new BinarySearchTreeController(_mockBinarySearchTreeManager.Object);
    }

    [Test]
    public void CheckNode_ShouldReturnTrue()
    {
        // Arrange
        TreeNode root = new TreeNode
        {
            Value = 2,
            Left = new TreeNode { Value = 1 },
            Right = new TreeNode { Value = 3 }
        };
        _mockBinarySearchTreeManager.Setup(x => x.IsValidBinarySearchTree(root)).Returns(true);

        // Act
        ActionResult<bool> result = _binarySearchTreeController.CheckNode(root);

        // Assert
        Assert.IsTrue(result.Value);
    }

    [Test]
    public void CheckNode_ShouldReturnFalse()
    {
        // Arrange
        TreeNode root = new TreeNode
        {
            Value = 5,
            Left = new TreeNode { Value = 1 },
            Right = new TreeNode
            {
                Value = 4,
                Left = new TreeNode { Value = 3 },
                Right = new TreeNode { Value = 6 }
            }
        };
        _mockBinarySearchTreeManager.Setup(x => x.IsValidBinarySearchTree(root)).Returns(false);

        // Act
        ActionResult<bool> result = _binarySearchTreeController.CheckNode(root);

        // Assert
        Assert.IsFalse(result.Value);
    }
}

