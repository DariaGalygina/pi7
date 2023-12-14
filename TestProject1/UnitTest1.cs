namespace TestProject1
{
    using pi;
    public class Tests
    {
        [Test]
        public void IsPrime_ReturnsFalse_WhenNumberIsOne()
        {
            Assert.IsFalse(Program.IsPrime(1));
        }

        [Test]
        public void IsPrime_ReturnsTrue_WhenNumberIsTwo()
        {
            Assert.IsTrue(Program.IsPrime(2));
        }

        [Test]
        public void IsPrime_ReturnsTrue_WhenNumberIsThree()
        {
            Assert.IsTrue(Program.IsPrime(3));
        }

        [Test]
        public void IsPrime_ReturnsFalse_WhenNumberIsNine()
        {
            Assert.IsFalse(Program.IsPrime(9));
        }
    }
}