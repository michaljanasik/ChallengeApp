using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    public class Person
    {

        string name;
        string surname;

        public Person()
        {

        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        //---------------------------------------------
        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            protected set { this.surname = value; }
        }





        //--------------------------------------------------------
    }
}
