// TreeNode class represents a node in a binary tree.
// Each node contains an integer value and references to its left and right child nodes.
// This class is used as a data transfer object (DTO) for serializing and deserializing binary tree nodes.
namespace API.DTOs
{
    public class TreeNode
    {
        // Gets or sets the integer value of the node.
        public int Value { get; set; }

        // Gets or sets the reference to the left child node.
        public TreeNode Left { get; set; }

        // Gets or sets the reference to the right child node.
        public TreeNode Right { get; set; }
    }
}