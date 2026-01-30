using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2_OOP;

namespace MasterclassTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Arrange
            var account = new BankAccount("Patryk", 100m);

            // Act
            account.Withdraw(40m);

            // Assert
            Assert.AreEqual(60m, account.GetBalance());
        }
    }
}