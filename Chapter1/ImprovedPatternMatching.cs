namespace Chapter1.ImprovedPatternMatching
{
    #region Improved_Pattern_Matching

    public class Improved_Pattern_Matching
    {
        public Improved_Pattern_Matching() { }

        public int MainProgramTXSelector()
        {
            var product = new Product() { Name = "Food", CategoryId = 4 };
            return GetTax(product);
        }

        private int GetTax(Product p) => p.CategoryId switch
        {
            0 or 1 => 0,
            > 1 and < 5 => 5,
            > 20 => 15,
            _ => 20
        };
    }    


    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
    }

    #endregion

    #region Not_pattern

    public class ElectronicProduct : Product
    {

    }

    public class DiscountSelector
    {
        public DiscountSelector() { }
        
        public void MainProgram()
        {
            var product = new Product() { Name = "Food", CategoryId = 4 };
            Console.WriteLine($"Improved not pattern matching GetDiscount -> {GetDiscount(product)}");
            Console.WriteLine($"Improved not pattern matching GetDiscountTernary -> {GetDiscountTernary(product)}");
        }

        private int GetDiscount(Product p)
        {
            if(p is not ElectronicProduct)
                return 25;
            
            return 0;
        }

        private int GetDiscountTernary (Product p) => p is not ElectronicProduct ? 25 : 0;
    }

    #endregion
}