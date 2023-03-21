namespace Chapter1.Models;

public class CountryReply
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Anthem { get; set; } = string.Empty;
    public string CapitalCity { get; set; } = string.Empty;
    public string FlagURI { get; set; } = string.Empty;
    public List<string> Languages { get; set; }
}
