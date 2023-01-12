using GenshinHelper.Core.Entities;

namespace GenshinHelper.Application.Common;

public class CharacterBuildDto
{
    public int Id { get; set; }
    public string Character { get; set; }
    public List<string> ArtifactSets { get; set; }
    public ArtifactStats ArtifactStats { get; set; }
    public List<string> ArtifactExtraStats { get; set; }
    public List<string> Weapons { get; set; }
    public Talents Talents { get; set; }
    public Stats Stats { get; set; }
}