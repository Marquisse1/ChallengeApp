using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSumAsResult_1()
        {
            //arrange
            var employee = new Employee("Marek", "Tester", 40);
            employee.AddPoints(5);
            employee.AddPoints(6);
            employee.AddPoints(4);

            employee.SubPoints(15);

            //act
            var result = employee.Score;

           //assert
           Assert.AreEqual(0, result);
        }
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSumAsResult_2()
        {
            //arrange
            var employee = new Employee("Marek", "Tester", 40);
            employee.AddPoints(5);
            employee.AddPoints(2);
            employee.AddPoints(1);

            employee.SubPoints(10);

            //act
            var result = employee.Score;

            //assert
            Assert.AreEqual(-2, result);
        }
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectSumAsResult_3()
        {
            //arrange
            var employee = new Employee("Marek", "Tester", 40);
            employee.AddPoints(10);
           
            employee.SubPoints(6);
            employee.SubPoints(2);
            employee.SubPoints(1);

            //act
            var result = employee.Score;

            //assert
            Assert.AreEqual(1, result);
        }
    }
}