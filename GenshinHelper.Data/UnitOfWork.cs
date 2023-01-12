using GenshinHelper.Core.Interfaces;

namespace GenshinHelper.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly CharacterBuildContext _context;

    public UnitOfWork(CharacterBuildContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }
}