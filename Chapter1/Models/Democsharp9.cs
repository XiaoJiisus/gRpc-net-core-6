namespace Chapter1.Models
{
    public class Democsharp9
    {
        public string Name { get; set; }
        public int CategoryId { get; init; }
        public bool ShowNameId => !string.IsNullOrEmpty(Name);
    }
}