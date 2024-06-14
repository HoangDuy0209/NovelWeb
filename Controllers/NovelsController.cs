using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovelReadingApplication.Models;
using NovelReadingApplication.Services.Interfaces;

[ApiController]
[Route("[controller]")]
public class NovelsController : ControllerBase
{
    private INovelService novelService;

    public NovelsController(INovelService novelService)
    {
        this.novelService = novelService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(novelService.GetAllNovels());
    }

    [HttpPost]
    public IActionResult Add([FromBody] Novel novel)
    {
        novelService.AddNovel(novel);
        return Ok();
    }
}