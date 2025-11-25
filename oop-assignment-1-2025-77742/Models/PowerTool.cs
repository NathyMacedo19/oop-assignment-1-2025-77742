using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_77742.Models
{
    public class PowerTool : Tool, NoBorrowable
    {
        public bool Borrowed { get; private set; }

        public PowerTool(
            string manufacturer, 
            string model, 
            string toolType, 
            string serialNumber, 
            double price, 
            bool borrowed )
            : base(manufacturer, model, toolType, serialNumber, price)
        {
            Borrowed = borrowed;
        }

       
        // manufacturer + model + toolType
        public PowerTool(
            string manufacturer, 
            string model, 
            string toolType)
            : base(manufacturer, model, toolType, "UNKNOWN", 0.0)
        {
            Borrowed = false;
        }

        // manufacturer + model
        public PowerTool(string manufacturer, string model)
            : base(manufacturer, model, "Unknown Tool", "UNKNOWN", 0.0)
        {
            Borrowed = false;
        }


        public void Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine("Tool borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Error: This tool is already on loan.");
            }
        }

        public void ReturnTool()
        {
            Borrowed = false;
            Console.WriteLine("Tool returned.");
        }

        public bool CheckBorrowed()
        {
            return Borrowed;
        }

        public override void Display()
        {
            Console.WriteLine("========== Power Tool Information ==========");
            Console.WriteLine($"Manufacturer : {Manufacturer}");
            Console.WriteLine($"Model        : {Model}");
            Console.WriteLine($"Tool Type    : {ToolType}");
            Console.WriteLine($"Serial Number: {SerialNumber}");
            Console.WriteLine($"Price        : €{Price:F2}");
            Console.WriteLine($"Borrowed     : {(Borrowed ? "Yes" : "No")}");
            Console.WriteLine("============================================");
        }


        
    }
}

