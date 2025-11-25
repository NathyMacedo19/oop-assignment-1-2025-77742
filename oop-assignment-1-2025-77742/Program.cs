// See https://aka.ms/new-console-template for more information

using oop_assignment_1_2025_77742.Models;

PowerTool tool1 = new PowerTool(
                "Bosch",
                "X200",
                "Drill",
                "SN001",
                199.99,
                false
            );


PowerTool tool2 = new PowerTool(
    "Makita",
    "M500",
    "Saw"
);


PowerTool tool3 = new PowerTool(
    "DeWalt",
    "D1000"
);

PowerTool tool4 = new PowerTool(
    "Black & Decker",
    "BD300",
    "Sander",
    "SN004",
    89.50,
    false
);


// show details of the program
Console.WriteLine("Tool 1:");tool1.Display();
Console.WriteLine("\nTool 2:");tool2.Display();
Console.WriteLine("\nTool 3:");tool3.Display();
Console.WriteLine("\nTool 4:");tool4.Display();

// show all tools

Console.WriteLine("\n=== Borrowing Tools ===");
tool1.Borrow();
tool1.Borrow(); // show erro

Console.WriteLine("\n=== Returning Tool ===");
tool1.ReturnTool();

Console.WriteLine("\n=== Changing Price ===");
tool4.ChangePrice(120.00);
Console.WriteLine($"New price: {tool4.CheckPrice()}");

Console.WriteLine("\n=== Checking Borrow Status ===");
Console.WriteLine($"Tool 1 borrowed? {tool1.CheckBorrowed()}");

Console.WriteLine("\n=== FINAL DISPLAY ===");
tool1.Display();
tool4.Display();

Console.WriteLine("\nProgram finished.");
