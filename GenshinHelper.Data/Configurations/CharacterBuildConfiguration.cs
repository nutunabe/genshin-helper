using GenshinHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenshinHelper.Data.Configurations;

public class CharacterBuildConfiguration : IEntityTypeConfiguration<CharacterBuild>
{
    public void Configure(EntityTypeBuilder<CharacterBuild> builder)
    {
        builder.HasKey(build => build.Id);
        builder.Property(build => build.Character);
        builder.Property(build => build.ArtifactSets);
        builder.Property(build => build.ArtifactStats);
        builder.Property(build => build.ArtifactExtraStats);
        builder.Property(build => build.Weapons);
        builder.Property(build => build.Talents);
        builder.Property(build => build.Stats);
    }
}