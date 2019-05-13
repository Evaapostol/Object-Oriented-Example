using System;

namespace ObjectOrientedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a name");
            string name = Console.ReadLine();
            //Console.WriteLine("Give an age");
            //int age = int.Parse(Console.ReadLine());
            Person person = new Person();
            //person.age = age;                                    
            //person.name = name;
            Console.WriteLine(person.ToString());
            Person p = new Person("Eugenia", "Apostol", "Ath", 25);
            Console.WriteLine(p.name);
            Book bk = new Book("fm", "Rose", "Eugenia", "Sp", 500, 2015,true);
            Console.WriteLine(bk.ToString());
            Console.WriteLine(bk);
            p.AssignBook(bk);
            Console.WriteLine(p);       
            bk.Rent();
            bk.ReturnBack();
            Employee empl = new Employee("eva", "apostol", "ath", 18, 1000);
            Console.WriteLine(empl);
            empl.AssignBook(new Book("1", "bible", "4 evaggelistes", "gutenberg", 1000, 50, true)); 
            Console.WriteLine(empl);
            
        }
    }

    class Person
    {
        string _firstName;                                    
        string _lastName;
        string _address;
        int _age;
        Book personalBook;                                    

        public void AssignBook( Book book)
        {
            personalBook = book;
        }


        public string name
        {
            get { return _firstName + " " + _lastName; }         
        }
        string address { get; set; }                          
        public int age { get; set; }


        public Person()                 
        {

        }


        public Person(string firstName, string lastName, string aaddress, int aage)                 
        {                                                                      
            _firstName = firstName;                                             
            _lastName = lastName;
            _address = aaddress;
            this.age = aage;
        }


        public override string ToString() 
        {
            return "Person name =" + name + " Person address = " + address + " Person age = " + age + "Personal Book" + personalBook;
        }
        public void increaseAge()
        {
            age++;
        }

        

    }

    class Employee: Person
    {
        double salary;

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string aaddress, int aag, double salary): base(firstName, lastName, aaddress, aag)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + " salary = " + salary;
        }
    }
    class Book
    {
        string isbm { get; set; }
        string title { get; set; }
        string author { get; set; }
        string publisher { get; set; }
        int numberOfPages { get; set; }
        int publishYear { get; set; }
        bool available { get; set; }

        public Book()
        {

        }

        public Book(string isbm, string title, string author, string publisher, int numberOfPages, int publishYear , bool available)
        {
            this.isbm = isbm;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.numberOfPages = numberOfPages;
            this.publishYear = publishYear;
            this.available = available;

        }

        
        public void Rent()
        {
            available = false;
        }

        public void ReturnBack()
        {
            available = true;
        }

        public override string ToString() 
        {
            return "isbm =" + isbm + " title = " + title + " author = " + author + "publisher= "
                + publisher + "numberOfPages" + numberOfPages + "publishYear" + publishYear + "available=" + available;
        }
    }
}
