using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1labaprogi
{
    public class Person
    {
        int age;
        string first_name;
        string second_name;
        double height;
        public Person(int Age, string FName, string SName, double Height)
        {
            age = Age;
            first_name = FName;
            second_name = SName;
            height = Height;
        }
    }
}
