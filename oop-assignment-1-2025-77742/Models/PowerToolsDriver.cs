using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_77742.Models
{
    public class PowerToolDriver
    {
        public static void Main(string[] args)
        {
            // Using all 3 constructors
            PowerTool drill = new PowerTool("Bosch", "X200", "Drill", "A111", 59.99, false);
            PowerTool saw = new PowerTool("Makita", "CutPro", "Saw");
            PowerTool sander = new PowerTool("DeWalt", "SmoothMaster");
            PowerTool grinder = new PowerTool("Hitachi", "GModel", "Grinder");

            List<PowerTool> tools = new List<PowerTool>()
        {
            drill, saw, sander, grinder
        };

            Console.WriteLine("\n===== Displaying All Tools =====");
            foreach (var tool in tools)
                tool.Display();

            // Calling all methods
            drill.Borrow();
            drill.Borrow();  // Should print error
            drill.ReturnTool();

            saw.ChangePrice(79.99);
            
            Console.WriteLine($"Saw Price: {saw.CheckPrice()}");

            Console.WriteLine($"Is Grinder Borrowed? {grinder.CheckBorrowed()}");
        }
    }
}
