namespace Chapter1.Models
{
    public class Product_InitOnly
    {
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; init; }
        public bool ShowNameId => !string.IsNullOrEmpty(Name);
    }
}