using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        //Testy typów referencyjnych

        [Test]
        public void GetTwoDifferentEmployeesShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Adamski", 20);
            var employee2 = GetEmployee("Bartek", "Bartkowski", 25);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void GetTwoSameLookingEmployeesShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Adamski", 20);
            var employee2 = GetEmployee("Adam", "Adamski", 20);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void GetTwoSameLookingEmployeesShouldReturnSameName()
        {
            //Uwaga - zgodność następuje dopiero odnośnie parametrów wewnątrz klasy.

            //arrange
            var employee1 = GetEmployee("Adam", "Adamski", 20);
            var employee2 = GetEmployee("Adam", "Adamski", 20);

            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void WhenTwoDifferentStringVariablesValuesShouldBeNotEqual()
        {
            //arrange
            string item1 = "rzecz pierwsza";
            string item2 = "rzecz druga";

            //act

            //assert
            Assert.AreNotEqual(item1, item2);
        }

        [Test]
        public void WhenTwoSameStringVariablesValuesShouldBeEqual()
        {
            //Uwaga - przykład stanowi wyjątek wśród typów referencyjnych.
            //Charakteryzuje się zgodnością wartości obydwu zmiennych, podobnie jak w przypadku typu wartościowego.

            //arrange
            string item1 = "rzecz";
            string item2 = "rzecz";

            //act

            //assert
            Assert.AreEqual(item1, item2);
        }

        //Testy typów wartościowych

        [Test]
        public void WhenTwoDifferentIntVariablesValuesShouldBeNotEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenTwoSameIntVariablesValuesShouldBeEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenTwoDifferentFloatVariablesValuesShouldBeNotEqual()
        {
            //arrange
            float number1 = 0.5F;
            float number2 = 2.5F;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenTwoSameFloatVariablesValuesShouldBeEqual()
        {
            //arrange
            float number1 = 0.5F;
            float number2 = 0.5F;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
    }
}
