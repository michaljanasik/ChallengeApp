using ChallengeApp;

namespace challangeApp.Test
{
   
    internal class variablesTest
    {
        [Test]
        public void myVariablesTest() {

            //arrange

            float a, b, c;
            a = (float)23.9; b = (float)23.9; 

            int f;
            f = 45;

            //act

            //assert
            Assert.AreEqual(a, b);//float
            Assert.NotZero(f);//int
    }
        [Test]
        public void referencesTest()
        {
            Employee e1 = new Employee("bartek", "kania", 23);
            Employee e2 = new Employee("asia", "kania", 13);
          

            e1 = e2;//pointing the same memory place

            Assert.AreEqual(e1, e2);
        }
    }
}
