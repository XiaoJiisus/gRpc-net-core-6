namespace Chapter1.CovaritanReturns
{
    public abstract class Product
    {
        protected string Name { get; }
        protected int Id { get; }

        protected Product(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract ProductOrder Order(int quantity);
    }

    public class Book : Product
    {
        public string ISBN { get; }

        public Book(string name, int categoryId, string isbn) : base (name, categoryId)
        {
            ISBN = isbn;
        }

        public override BookOrder Order(int quantity) => new BookOrder { Quantity = quantity, Product = this };
    }

    public class ProductOrder
    {
        public int Quantity { get; set; }
    }

    public class BookOrder : ProductOrder
    {
        public Book Product { get; set; }
    }
}