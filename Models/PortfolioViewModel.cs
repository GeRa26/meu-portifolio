namespace DevPortfolio.Models;

public class PortfolioViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string AboutMe { get; set; } = string.Empty;
    public string AboutMeExtended { get; set; } = string.Empty;
    public string CvFileUrl { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;
    public List<Project> Projects { get; set; } = new List<Project>();
    public List<SkillCategory> SkillCategories { get; set; } = new List<SkillCategory>();
    public List<Experience> Experiences { get; set; } = new List<Experience>();
}
