namespace GenshinHelper.Core.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public string Vision { get; set; }
        // public int Rarity { get; set; }
        // public string Weapon { get; set; }
        public List<SkillTalent> SkillTalents { get; set; }
        // public List<PassiveTalentModel> PassiveTalents { get; set; }
        // public int Constellation { get; set; }
        public MainStats Stats { get; set; }
    }
}
