
using challangeApp;

namespace challangeApp.Test
{
        public class EmployeeTest
        {

            //Act for all tests

            Employee em1 = new Employee("aa", "bb");
            Statistics st1 = new Statistics();

            Statistics Prepare(Employee tmp)
            {
                tmp.AddGrade((float)6.0);
                tmp.AddGrade((float)4.0);
                tmp.AddGrade((float)8.0);

                return tmp.getStatistics();
            }




            [Test]

            public void CheckAverrage_ShouldBeEqualLikeGiven()
            {   //act  
                Statistics StLocal;


                //arrange
                StLocal = this.Prepare(em1);

                //Assert

                Assert.AreEqual(6, StLocal.Average);

            }

            [Test]  
            public void MinimumValueShouldBeGreatherThenGiven()
            {
                //Act
                em1.AddGrade((float)4.0);

                //Arrange
                st1 = this.Prepare(em1);

                //Assert

                Assert.Greater(st1.Min, 1);
            }

            [TestCase((float)4.7)]
            [TestCase((float)1.2)]
            [TestCase((float)4.5)]

            public void MakeFewTestsAndExpectAverageAlwaysLessThenGiven(float tmp)
            {
                //act
                em1.AddGrade(tmp);

                //arrange
                st1 = this.Prepare(em1);

                //assert

                Assert.Less(st1.Average, 10);

            }
        }
    }
