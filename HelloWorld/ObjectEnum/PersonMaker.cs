using System;
namespace HelloWorld.ObjectEnum

{
    public class Person
    {
        private int Age;

        public Person(int age)
        {
            this.Age = age;
        }

        public void GetOlder()
        {
            this.Age += 1;   
        }

        public int GetAge()
        {
            return this.Age;
        }
    }

    public class AlternatePerson
    {
        public int Age;
    }

}
