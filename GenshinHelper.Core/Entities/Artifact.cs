namespace GenshinHelper.Core.Entities;

public class Artifact
{
    public string Name { get; set; }
    public string MainStat { get; set; }
    public string ExtraStat { get; set; }
    public ArtifactType Type { get; set; }
}