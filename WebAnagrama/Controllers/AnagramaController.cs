using Microsoft.AspNetCore.Mvc;

namespace WebAnagrama.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnagramaController : ControllerBase
    {
        [HttpGet("{firstString}/{secondString}")]
        public bool Get(string firstString, string secondString)
        {
            Anagram anagram = new Anagram();
            anagram.areAnagram(firstString, secondString);
            return anagram.Valid;
        }
    }
}
