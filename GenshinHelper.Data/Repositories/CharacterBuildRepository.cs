using GenshinHelper.Core.Entities;
using GenshinHelper.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GenshinHelper.Data.Repositories;

public class CharacterBuildRepository : ICharacterBuildRepository
{
    private readonly DbSet<CharacterBuild> _dbSet;

    public CharacterBuildRepository(CharacterBuildContext buildContext)
    {
        _dbSet = buildContext.Set<CharacterBuild>();
    }

    public void AddBuild(CharacterBuild build) => _dbSet.Add(build);

    public void DeleteBuild(CharacterBuild build) => _dbSet.Remove(build);

    public void UpdateBuild(CharacterBuild build) => _dbSet.Update(build);

    public async Task<CharacterBuild?> GetBuildAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<CharacterBuild>> GetAllBuildsAsync()
    {
        return await _dbSet.ToListAsync();
    }
}