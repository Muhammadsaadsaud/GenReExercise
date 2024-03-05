using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

// BinarySearchTreeController handles HTTP requests related to binary search trees.
[Route("[controller]")]
[ApiController]
public class BinarySearchTreeController(IBinarySearchTreeManager treeManager) : ControllerBase
{
    private readonly IBinarySearchTreeManager treeManager = treeManager;

    // Endpoint to check if a given binary tree is a valid binary search tree (BST).
    [HttpPost("checkNode")]
    public ActionResult<bool> CheckNode([FromBody] TreeNode root)
    {
        // Call IsValidBinarySearchTree method of treeManager.
        return treeManager.IsValidBinarySearchTree(root);
    }
}
