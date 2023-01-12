namespace GenshinHelper.Core.Entities;

public class SkillTalent
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public SkillType Type { get; set; }
    public int Priority { get; set; }
}