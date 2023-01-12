using GenshinHelper.Core.Entities;

namespace GenshinHelper.Core.Repositories;

public interface ICharacterBuildRepository
{
    void AddBuild(CharacterBuild build);
    void DeleteBuild(CharacterBuild build);
    void UpdateBuild(CharacterBuild build);
    Task<CharacterBuild?> GetBuildAsync(int id);
    Task<IEnumerable<CharacterBuild>> GetAllBuildsAsync();
}