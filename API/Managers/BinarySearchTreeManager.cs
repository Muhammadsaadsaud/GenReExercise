using API.DTOs;
using API.Interfaces;

namespace API.Managers;

// BinarySearchTreeManager implements the IBinarySearchTreeManager interface.
public class BinarySearchTreeManager : IBinarySearchTreeManager
{
    // Determines whether the given binary tree is a valid binary search tree (BST).
    public bool IsValidBinarySearchTree(TreeNode root)
    {
        // Implementation of the logic to check if the binary tree is a valid binary search tree

        // Base case: If the root is null, it is a valid BST.
        if (root == null)
        {
            return true;
        }

        // Check if the left child's value is less than the root value.
        // If not, the tree is not a valid BST.
        if (root.Left != null && root.Left.Value >= root.Value)
        {
            return false;
        }

        // Check if the right child's value is greater than the root value.
        // If not, the tree is not a valid BST.
        if (root.Right != null && root.Right.Value <= root.Value)
        {
            return false;
        }

        // Recursively check if both the left and right subtrees are valid BSTs.
        return IsValidBinarySearchTree(root.Left) && IsValidBinarySearchTree(root.Right);
    }
}
