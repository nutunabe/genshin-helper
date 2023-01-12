namespace GenshinHelper.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> Complete();
}