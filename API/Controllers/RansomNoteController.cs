using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

// RansomNoteController handles HTTP requests related to ransom notes.
[Route("[controller]")]
[ApiController]
public class RansomNoteController(IRansomNoteManager ransomNoteManager) : ControllerBase
{
    private readonly IRansomNoteManager ransomNoteManager = ransomNoteManager;

    // Endpoint to check if a ransom note can be constructed from a given magazine.
    [HttpGet("canConstruct")]
    public ActionResult<bool> CanConstruct([FromQuery] string ransom, [FromQuery] string magazine)
    {
        // Calling CanConstructRansomNote of ransomNoteManager.
        return ransomNoteManager.CanConstructRansomNote(ransom, magazine);
    }
}
