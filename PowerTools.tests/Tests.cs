using oop_assignment_1_2025_77742.Models;

namespace PowerTools.tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]

        //Borrow()
        public void Borrow_ShouldSetBorrowedToTrue()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, false);

            tool.Borrow();

            Assert.IsTrue(tool.CheckBorrowed());
        }

        // Borrow() errro case
        public void Borrow_WhenAlreadyBorrowed_ShouldStayTrue()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, true);

            tool.Borrow();

            Assert.IsTrue(tool.CheckBorrowed());
        }

        //RetornTool()
        public void ReturnTool_ShouldSetBorrowedToFalse()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, true);

            tool.ReturnTool();

            Assert.IsFalse(tool.CheckBorrowed());
        }

        //ChangePrice()
        public void ChangePrice_ShouldUpdatePrice()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, false);

            tool.ChangePrice(79.99);

            Assert.AreEqual(79.99, tool.CheckPrice());
        }


        // CheckPrice()
        public void CheckPrice_ShouldReturnCorrectPrice()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, false);

            Assert.AreEqual(50, tool.CheckPrice());
        }


        //CheckBorrowed()
        public void CheckBorrowed_ShouldReturnCorrectState()
        {
            var tool = new PowerTool("Bosch", "X200", "Drill", "123", 50, true);

            Assert.IsTrue(tool.CheckBorrowed());
        }
                
    }

}
