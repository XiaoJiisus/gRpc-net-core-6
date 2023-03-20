namespace Chapter1.Models
{
    //immutable product record with a primary constructor
    public record ProductCtor(string Name, int CategoryId);


    //immutable product record with init-only properties
    public record Product
    {
        public string Name { get; init; }
        public int CategoryId { get; init; }
    }
}