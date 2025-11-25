using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_77742.Models
{
    public abstract class Tool
    {
        public string Manufacturer { get; protected set; }
        public string Model { get; protected set; }
        public string ToolType { get; protected set; }
        public string SerialNumber { get; protected set; }
        public double Price { get; protected set; }

        public Tool(string manufacturer, string model, string toolType, string serialNumber, double price)
        {
            ValidateString(manufacturer, "Manufacturer");
            ValidateString(model, "Model");
            ValidateString(toolType, "Tool Type");
            ValidateString(serialNumber, "Serial Number");
            ValidatePrice(price);

            Manufacturer = manufacturer;
            Model = model;
            ToolType = toolType;
            SerialNumber = serialNumber;
            Price = price;
        }

        // Validation methods
        protected void ValidateString(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{fieldName} cannot be empty.");
            }
        }

        protected void ValidatePrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
        }

        public void ChangePrice(double newPrice)
        {
            ValidatePrice(newPrice);
            Price = newPrice;
        }

        public double CheckPrice()
        {
            return Price;
        }

        // Abstract method to be implemented in the concrete class
        public abstract void Display();
    }

}
