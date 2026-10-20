namespace OOPs
{
    class Person_1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person_1(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }//Data Member || Instance Field || Attribute || Property
        public int Age { get; set; }
        public long MobileNo { get; set; } // what if i write private instead of Public 

        //member function || behaviour

        public void DisplayPerson()
        {
            Console.WriteLine($"Person Details :- {Name} , {Age} , {MobileNo}");
        }

        public void AcceptPerson(string name , int age ,  long mobileno)
        {
            Name = name; Age = age; MobileNo = mobileno;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.AcceptPerson("Onkar" , 24 , 8788659835);
            Console.WriteLine("P :- Onkar , 24 , 8788659835");
            p.DisplayPerson();

            Console.WriteLine("----------------------------------");
            Person p2 = new Person();
            p2.Name = "Ganesh"; p2.Age = 42; p2.MobileNo = 9012345678;

            p2.DisplayPerson();
            Console.WriteLine("Accept p2 person \"Ramesh\" , 60 , 9420015049");
            p2.AcceptPerson("Ramesh" , 60 , 9420015049);
            p2.DisplayPerson();
        }
    }
}
