using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    internal interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        string sayHello { get; }

        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(float grade);

        Statistics GetStatistics();


    }
}
