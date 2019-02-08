using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //method
    //field
    //constructor
    class Student
    {
        private string name;
        private string id;        //sozdaesh fieldy
        public int yearofstudy;

        public Student()
        {
            name = "asdfasf";
            id = "asdfsfd";         //constructor
            yearofstudy = 0;
        }
        public Student(string name, string id) // parameters
        {
            this.name = name;
            this.id = id;
        }

        public string getName()
        {
            return this.name;    //vozrashaem name potomu chto on private a  esli private to u nas net dostupa k etomu fieldu.
        }
        
        public string getId()
        {
            return this.id;
        }

        public int increment()
        {
            return ++yearofstudy;    //incrementim  yearofstudy i vozrashaem
        }
    }
}
