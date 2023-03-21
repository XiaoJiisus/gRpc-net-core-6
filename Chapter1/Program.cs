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

Console.WriteLine($"Is record equal to new record product from with keyworkd? -> {recordProduct.Equals(newRecordProduct)}");

var anotherProduct = new Product_Record_Ctor( Name: "VideoGame", CategoryId: 1);
Console.WriteLine($"Is record equal to another object from same ctor? -> {recordProduct.Equals(anotherProduct)}");

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*      Improved Pattern Matching      *");
Console.WriteLine($"***************************************");

var testTXSelector = new Improved_Pattern_Matching();
Console.WriteLine($"Improved Pattern Matching with using tax selector -> {testTXSelector.MainProgramTXSelector()}");

var discountSelector = new DiscountSelector();
discountSelector.MainProgram();

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*       Improved Target Typing        *");
Console.WriteLine($"***************************************");

var improvedTargetObj = new ProgramImprovedTargetTyping();
improvedTargetObj.MainProgramBook();

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*         Covariant  returns          *");
Console.WriteLine($"***************************************");

// var covariantObj = new Book();

Console.WriteLine($"                                       ");
Console.WriteLine($"                                       ");
Console.WriteLine($"***************************************");
Console.WriteLine($"*     Static anonymus functions       *");
Console.WriteLine($"***************************************");

var allocationMemory = new UnintendedMemoryAllocation();
allocationMemory.Main();

var allocationMemoryFix = new UnintendedMemoryAllocationFix();
allocationMemoryFix.Main();