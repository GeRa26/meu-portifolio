namespace DevPortfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = new List<string>();
    public string GithubUrl { get; set; } = string.Empty;
    public string LiveUrl { get; set; } = string.Empty;
}
