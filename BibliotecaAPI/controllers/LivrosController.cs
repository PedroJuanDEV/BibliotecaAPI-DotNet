using BibliotecaAPI.Models;
using BibliotecaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private readonly ILivroRepository _repository;

    public LivrosController(ILivroRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpPost]
    public async Task<ActionResult<Livro>> PostLivro(Livro livro)
    {
        await _repository.AddAsync(livro);
        return CreatedAtAction(nameof(GetLivros), new { id = livro.Id }, livro);
    }
}