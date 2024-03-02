
using challangeApp;

namespace challangeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void ExpectedAverrageMustBeGratherThenGiven()
        {

            Employee empl1 = new Employee();


            //Arrange
            empl1.AddGrade("B");
            empl1.AddGrade("a");
            empl1.AddGrade("89,5");

            //Act
            empl1.ShowGrades(); //Is filling my employee
            //Assert
            Assert.Greater(empl1.Averrage, 20);
        }

        [TestCase((float)90.7)]
        [TestCase((float)90.2)]
        [TestCase((float)70.5)]


        public void ExpectedAvverageGrade2ShouldBeGratherThenGiven(float tmp)
        {
            Employee empl2 = new Employee();

            //Arrange
            empl2.AddGrade("A");
            empl2.AddGrade("a");
            empl2.AddGrade("89,5");

            empl2.AddGrade(tmp);

            //Act

            empl2.ShowGrades();   //Is filling my employee


            //Assert
            Assert.GreaterOrEqual(empl2.Averrage, 80);

        }
    }
}
