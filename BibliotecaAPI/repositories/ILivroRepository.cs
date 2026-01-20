using BibliotecaAPI.Models;

namespace BibliotecaAPI.Repositories;

public interface ILivroRepository
{
    Task<IEnumerable<Livro>> GetAllAsync();
    Task AddAsync(Livro livro);
}