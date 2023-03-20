namespace Chapter1.Models
{
    //immutable product record with a primary constructor
    public record Product_Record_Ctor(string Name, int CategoryId);


    //immutable product record with init-only properties
    public record Product_Record
    {
        public string Name { get; init; } = string.Empty;
        public int CategoryId { get; init; }
    }
}