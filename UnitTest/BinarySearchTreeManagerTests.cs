using API.Managers;
using API.DTOs;

namespace UnitTest;

[TestFixture]
public class BinarySearchTreeManagerTests
{
    private BinarySearchTreeManager _binarySearchTreeManager;

    [SetUp]
    public void Setup()
    {
        _binarySearchTreeManager = new BinarySearchTreeManager();
    }

    [Test]
    public void IsValidBinarySearchTree_ShouldReturnTrue()
    {
        // Arrange
        TreeNode root = new TreeNode
        {
            Value = 2,
            Left = new TreeNode { Value = 1 },
            Right = new TreeNode { Value = 3 }
        };

        // Act
        bool result = _binarySearchTreeManager.IsValidBinarySearchTree(root);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidBinarySearchTree_ShouldReturnFalse()
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

        // Act
        bool result = _binarySearchTreeManager.IsValidBinarySearchTree(root);

        // Assert
        Assert.IsFalse(result);
    }
}

