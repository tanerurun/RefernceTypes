using System;

namespace RefernceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ,decimal,float,enum,boolean,value types
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            Console.WriteLine("number 1 : "+ number1);            

            //arrays,class,interface  ... reference types
            int[] numbers1=new int[] {1,2,3,4,5,6 };
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50, 60 };
            numbers1 = numbers2;
            numbers2[0] = 99;
            Console.WriteLine("numbers1  : " + numbers1[0]);
            
            Person person1 = new Person();
            Person person2 = new Person();
            person1.firstName = "Taner";
            person2 = person1;//person1 referance adresine person2 'ye aktarmış oluyoruz.
            person1.firstName = "Haşim ";

            Console.WriteLine(person2.firstName);
            
            Customer customer=new Customer();
            customer.firstName = "Poyraz";

            Employee employee=new Employee();

            Person person3 = customer;
            person3.firstName = "Yusuf";

            Console.WriteLine(person3.firstName);
            Console.WriteLine("-----------------------------------------------------------------------");


            PersonManager personManager = new PersonManager();
            personManager.add(employee);


            Console.ReadKey();
        }
    }
    //base class :Person
    class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
    class Customer:Person
    {
        public string carditCartNumber { get; set; }
    }
    class Employee:Person
    {
        public int employeeNumber { get; set; }
    }
    class PersonManager
    {
          public void add(Person person)
        {
            Console.WriteLine(person.firstName);
        }
    }
}
