using System;
using System.Collections.Generic;
using System.Collections;               // import arraylist libraries
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BVEatsMenuApp;

namespace BCEatsMenuApp
{
    class Program
    {
        enum BCEatsApp
        {//enum Menu
            Register = 1,
            ViewRegisteredMembers,
            PLaceAnOrder,
            ViewPlacedOrders,
            Exit,
        }
       
        static void Main(string[] args)
        {// List creation and variables
            List<Student> students = new List<Student>();
            List<Letcure> lecturers = new List<Letcure>();
            List<object> orders = new List<object>(); 
            string name, surname;
            double id;
          
            bool Continue = true;
            while (Continue)
            {// Loop and visual display of menu items to choose
                Console.WriteLine("1. Register for app");
                Console.WriteLine("2. View registered members");
                Console.WriteLine("3. Place an order");
                Console.WriteLine("4. View placed orders");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter a menu number" );
                int answer = int.Parse(Console.ReadLine());

                switch ((BCEatsApp)answer)
                {
                    case BCEatsApp.Register:
                        do
                        {// Code for registering a new student or lecturer by capturing their details
                            Console.WriteLine("Enter your name:");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter your surname:");
                            surname = Console.ReadLine();
                            Console.WriteLine("Please enter your ID:");
                            id = double.Parse (Console.ReadLine());    
                            Console.WriteLine("Are you a student or lecturer?");
                            if (Console.ReadLine() == "Student" || Console.ReadLine() == "student")
                            {
                                Student student = new Student(name, surname, id); // Assign to student list
                                students.Add(student);
                            }
                            else 
                            {
                                Letcure lecturer = new Letcure(name, surname, id);// Assign to Lecture list
                                lecturers.Add(lecturer);
                            }
                            Console.WriteLine("Do you want to register more members? Enter Y for Yes and N for No");
                        } while (Console.ReadLine().ToUpper() == "Y"); // For repeating the register code to capture more data
                        break;
                    case BCEatsApp.ViewRegisteredMembers:
                        Console.WriteLine("Registered members are: " );// Displaying registered students
                        Console.WriteLine("Students:\n---------------------------------------------------------------------");
                        foreach(Student student in students) 
                        {
                            Console.WriteLine(student.ToString());
                        }
                        Console.WriteLine("Lecturers:\n---------------------------------------------------------------------");
                        foreach (Letcure lecturer in lecturers)// Displaying registered lecturers
                        {
                            Console.WriteLine(lecturer.ToString());
                        }

                        break;
                    case BCEatsApp.PLaceAnOrder:// Ordering for a student or lecture
                        Console.WriteLine("Is the order for a Student or Lecturer?");
                        string type = Console.ReadLine();   
                        Console.WriteLine("Please enter the name of the person you want to order for?");
                        string search = Console.ReadLine();
                        if (type == "Student") // searching for student name in list
                        {
                            foreach(Student s in students) 
                            {
                                if (s.Name == search) 
                                {
                                    orders.Add(s);
                                    Console.WriteLine("Order placed successfully");
                                }
                                else 
                                {
                                    Console.WriteLine("Please register the student before attempting to place an order.");
                                }
                            }
                        }
                        else 
                        {
                            foreach (Letcure l in lecturers)// searching for lecturer name in list
                            {
                                if (l.Name == search)
                                {
                                    orders.Add(l);
                                    Console.WriteLine("Order placed successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Please register the lecturer before attempting to place an order.");
                                }
                            }
                        }
                        

                        break;
                    case BCEatsApp.ViewPlacedOrders:// Appriopriate message for successful order
                        Console.WriteLine("The order placed are for the following members:");
                        foreach(object o in orders) 
                        {
                            Console.WriteLine(o);
                        }
                        break;
                    case BCEatsApp.Exit: //Exiting the loop
                        Continue = false;
                        Environment.Exit(0);
                        break;


                }
                Thread.Sleep(3000);   // wait 3 seconds

            }
            Console.ReadLine();


        }
    }
}
