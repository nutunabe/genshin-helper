using GenshinHelper.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GenshinHelper.Data;

public class CharacterBuildContext : DbContext
{
    public CharacterBuildContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CharacterBuildConfiguration());
        base.OnModelCreating(builder);
    }
}