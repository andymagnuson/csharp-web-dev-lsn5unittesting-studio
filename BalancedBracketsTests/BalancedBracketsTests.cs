using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]    //Testing that brackets in the correct order return true
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]    //Testing that brackets in the incorrect order return false
        public void OnlyBracketsWrongOrderReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        
        [TestMethod]    //Testing that open bracket only returns false
        public void OpenBracketOnlyReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]    //Testing that closed bracket only returns false
        public void ClosedBracketOnlyReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]    //Testing that brackets around a string return true
        public void BracketsOnOutsideReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[SampleString]"));
        }

        [TestMethod]    //Testing that intenal brackets in a string return true
        public void IntenalBracketsCorrectOrderReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Sample[St]ring"));
        }


        [TestMethod]    //Testing that brackets around a string in wrong order return false
        public void BracketsOnOutsideWrongOrderReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]SampleString["));
        }

        [TestMethod]    //Testing that too many of one bracket returns false
        public void MoreOpenThanClosedReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Sa[mpleString]"));
        }

        [TestMethod]    //Testing that an empty string is balanced
        public void EmptryStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]    //Testing multiple sets of brackets in wrong order returns false
        public void MultipleBracketsOutOfOrderReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Sa[mp]leString]"));
        }

        [TestMethod]    //Testing multiple sets of brackest in the correct order returns true
        public void MultipleBracketseCorrectReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Sa]m[]ple[String]"));
        }

        [TestMethod]    //Testing that multiple sets of brackets with one in the incorrect order return false
        public void MultipleBracketsWrongOrderReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Sa]m][pleStr[ing]"));
        }
    }
}
