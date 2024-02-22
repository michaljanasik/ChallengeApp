using ChallengeApp;

namespace challangeApp.Test
{
    public class EmployeeTests
    {


        [Test]
        public void IfScoreIsGraterThen_2_ExamIsPassed()
        {//Arrange
            Employee e1 = new Employee("Iza", "Kapusta", 25);
            e1.AddScore(-1);
            e1.AddScore(6);
            e1.AddScore(10);

            //Act
            int result = e1.SumScore();


            //Assert

            Assert.Greater(result, 2);

        }
    }
}