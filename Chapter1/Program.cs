// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// var testTXSelector = new TaxSelector();
// Console.WriteLine($"Tax selector -> {testTXSelector.MainProgramTXSelector()}");

// var discountSelector = new DiscountSelector();
// discountSelector.MainProgram();

var allocationMemory = new UnintendedMemoryAllocation();
allocationMemory.Main();

Console.WriteLine("------------------------------------------");

var allocationMemoryFix = new UnintendedMemoryAllocationFix();
allocationMemoryFix.Main();