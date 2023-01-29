
using NUnit.Framework;
namespace Summator_2023.UnitTests
{
    public class Summator_2023Tests
    {

        [Test]
        public void Test_Summator_2023_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator_2023.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void Test_Summator_2023_SumTwoNegativetiveNumber()
        {
            var nums = new int[] { -1, -9 };
            var actual = Summator_2023.Sum(nums);
            var expected = -10;
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void Test_Summator_2023_Sum_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator_2023.Sum(nums);
            var expected = 6;
            //Assert.AreEqual(expected, actual);

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void Test_Summator_2023_SumZeroNumbers()
        {
            var nums = new int[] {0};
            var actual = Summator_2023.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}