using Chapter1.Models;

// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine($"***************************************");
Console.WriteLine($"*         Init-Only Properties        *");
Console.WriteLine($"***************************************");

var initOnlyProduc = new Product_InitOnly()
{
    Name = "Product with init accesor",
    CategoryId = 1
};

Console.WriteLine($"Init-Only Properties -> {System.Text.Json.JsonSerializer.Serialize(initOnlyProduc)}");

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*               Records               *");
Console.WriteLine($"***************************************");

var recordProduct = new Product_Record_Ctor( Name: "VideoGame", CategoryId: 1);
var newRecordProduct = recordProduct with { CategoryId = 2};

Console.WriteLine($"Record -> {System.Text.Json.JsonSerializer.Serialize(recordProduct)}");
Console.WriteLine($"New record from another -> {System.Text.Json.JsonSerializer.Serialize(newRecordProduct)}");

Console.WriteLine($"record is equal to new record product from with keyworkd -> {recordProduct.Equals(newRecordProduct)}");

var anotherProduct = new Product_Record_Ctor( Name: "VideoGame", CategoryId: 1);
Console.WriteLine($"record is equal to another keyworkd -> {recordProduct.Equals(anotherProduct)}");

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*      Improved Pattern Matching      *");
Console.WriteLine($"***************************************");
// var testTXSelector = new TaxSelector();
// Console.WriteLine($"Tax selector -> {testTXSelector.MainProgramTXSelector()}");

// var discountSelector = new DiscountSelector();
// discountSelector.MainProgram();

var allocationMemory = new UnintendedMemoryAllocation();
allocationMemory.Main();

Console.WriteLine("------------------------------------------");

var allocationMemoryFix = new UnintendedMemoryAllocationFix();
allocationMemoryFix.Main();