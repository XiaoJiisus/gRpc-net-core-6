namespace Chapter1.StaticAnonymousFunctions
{
    public class UnintendedMemoryAllocation
    {
        private string _text = "{0} is a beautiful product!";

        public void Main()
        {
            // text is captured that can cause unexpected retention or unexpected additional allocation
            PromoteProduct(product => string.Format(this._text, "Surface book 3"));
        }

        void PromoteProduct(Func<string, string> func)
        {
            var nonCapturedString = "";
            Console.WriteLine(func(nonCapturedString));
        }
    }

    public class UnintendedMemoryAllocationFix
    {
        const string _text = "{0} is a beautiful country!";// text must be declared as const

        public void Main()
        {
            PromoteCountry(static country => string.Format(_text, country)); // text is not captured
        }

        void PromoteCountry(Func<string, string> func)
        {
            var countries = new List<string> { "Canada", "France", "Japan" };

            foreach (var country in countries)
                Console.WriteLine(func(country));
        }
    }
}