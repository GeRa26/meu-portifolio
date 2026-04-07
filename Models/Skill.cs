namespace DevPortfolio.Models;

public class SkillCategory
{
    public string Title { get; set; } = string.Empty;
    public List<TechSkill> Skills { get; set; } = new List<TechSkill>();
}

public class TechSkill
{
    public string Name { get; set; } = string.Empty;
    public string DeviconClass { get; set; } = string.Empty;
    public string ColorHex { get; set; } = string.Empty; // For custom border/glow
}
