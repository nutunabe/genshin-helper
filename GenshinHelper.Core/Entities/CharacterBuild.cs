namespace GenshinHelper.Core.Entities;

public class CharacterBuild : BaseEnity
{
    public string Character { get; set; }
    public List<string> ArtifactSets { get; set; }
    public ArtifactStats ArtifactStats { get; set; }
    public List<string> ArtifactExtraStats { get; set; }
    public List<string> Weapons { get; set; }
    public Talents Talents { get; set; }
    public Stats Stats { get; set; }
}

public class ArtifactStats
{
    public string Sands { get; set; }
    public string Goblet { get; set; }
    public string Circlet { get; set; }
}

public class Talents
{
    public int NormalAttackLevel { get; set; }
    public int ElementalSkillLevel { get; set; }
    public int ElementalBurstLevel { get; set; }
}

public class Stats
{
    public int CritRate { get; set; }
    public int CritDamage { get; set; }
    public int EnergyRecharge { get; set; }
}
