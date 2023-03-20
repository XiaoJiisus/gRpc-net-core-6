namespace Chapter1.ImprovedTargetTyping
{
    public class ProgramImprovedTargetTyping
    {
        public void MainProgram()
        {
            Product product = new("Videogame", 1);
            var isTrue = false;

            // Compilation error: CS0173 Type of conditional expression cannot be determined because there is no implicit conversion between 'new(string, int)' and '<null>'
            //Product anotherProduct = isTrue ? new ("Videogame", 2) : null;
            
            // Compilation error: CS8754 There is no target type for new(string, int)
            // var anotherProduct2 = new ("VideoGame", 1);
        }

        public void MainProgram1()
        {
            Book aBook = new ("gRCP", 1);
            Headset headset = new ("Logitech", 2);

            // Compilation error prior C# 9, allowed by C# 9
            // Product anotherProduct = aBook ?? headset;
        }
    }

    public class Product
    {
        private string _name;
        private int _categoryId;

        public Product(string name, int categoryId)
        {
            _name = name;
            _categoryId = categoryId;
        }        
    }

    public class Book : Product
    {
        public Book(string name, int categoryId) : base(name, categoryId)
        {
        }
    }

    public class Headset : Product
    {
        public Headset(string name, int categoryId) : base(name, categoryId)
        {
        }
    }
}