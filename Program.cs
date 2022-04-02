using System;
using System.Collections.Generic;
using System.Diagnostics;
using Lab_10;
namespace lab12
{
    public  class Program
    {
        public static int GetCapacity()
        {
            int capacity = 0;bool success;
            do
            {
                success = int.TryParse(Console.ReadLine(), out capacity);
                if (!success)
                    Console.WriteLine(" Please try again");
            } while (!success);
            return capacity;
        }
        public static void Work()
        {

            MyCollection<Student> mycollection = new MyCollection<Student>();
            List<Student> students = new List<Student>();   
            int choice = 0, capacity; bool success = false;
            while(choice !=9 )
            {
                Console.WriteLine(" 1 - Create collection");
                Console.WriteLine(" 2 - Add Element");
                Console.WriteLine(" 3 - Add Range");
                Console.WriteLine(" 4 - Delete Element");
                Console.WriteLine(" 5 - Delete Range");
                Console.WriteLine(" 6 - Search");
                Console.WriteLine(" 7 - Copy My Collection");
                Console.WriteLine(" 8 - Print Collection");
                Console.WriteLine(" 9 - Exit");
                Console.WriteLine(" Enter your choice ");

                do
                {
                    success = int.TryParse(Console.ReadLine(), out choice);
                    if(!success)
                        Console.WriteLine(" Please try again");

                }while(!success);
                switch(choice)
                {
                        case 1:
                        {
                            Console.WriteLine(" Enter Capacity : ");
                             capacity = GetCapacity();
                            students = new List<Student>(capacity);
                            for (int i = 0; i < capacity; i++)
                                students.Add(Create_object());
                            mycollection = new MyCollection<Student>(students); 
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine(" Enter Capacity : ");
                             capacity= GetCapacity();
                            if (mycollection.list != null)
                                for (int i = 0; i < capacity; i++)
                                    mycollection.Add_element(Create_object());
                            else
                                Console.WriteLine(" You must create collection");
                            break;
                        }
                        case 3:
                        { 
                            Console.WriteLine(" Enter Capacity : ");
                            capacity = GetCapacity();
                            if (mycollection.list != null)
                            {
                                students = new List<Student>();

                                for (int i = 0; i < capacity; i++)
                                    students.Add(Create_object());
                                mycollection.Add_Range(students);
                            }
                            else
                                Console.WriteLine(" You must create collection");
                            break;

                        }
                        case 4:
                        {
                            if (mycollection.list != null)
                            {
                                Console.WriteLine(" Enter Capacity : ");
                                capacity = GetCapacity();
                                success = false;
                                //foreach (Student student in mycollection)
                                //    Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.GenderMale + " " + student.Section);
                                for (int i = 0; i < capacity; i++)
                                {
                                   
                                    Student student2 = new Student();
                                    student2 = Create_object();int id = 0;
                                    for (int j = 0; j < mycollection.list.Count; j++)
                                    {
                                        if (mycollection.list[j].Id == student2.Id)
                                        {
                                            success = true;
                                            id = j;
                                            break;
                                        }
                                    }
                                    if (success)
                                    {
                                        if (mycollection.list.Contains(mycollection.list[id]))
                                            mycollection.Delete_element(mycollection.list[id]);
                                        else
                                            Console.WriteLine(" Please enter correct ID");
                                    }
                                    else Console.WriteLine(" Not Found");
                                }
                            }
                            else
                                  Console.WriteLine(" This collection is Empty....!");
                            break ;
                        }
                        case 5:
                        {
                            if (mycollection.list != null)
                            {
                                Console.WriteLine(" Enter Point start ");
                                int start, count;
                                start = GetCapacity();
                                Console.WriteLine(" Enter number element you need delete");
                                count = GetCapacity();
                                mycollection.Delete_Range(start, count);
                            }
                            else
                                Console.WriteLine(" This collection is Empty...!");
                            break ;
                        }
                        case 6:
                        {
                            
                            Console.WriteLine(" Enter data for student you need searching");
                            Student std = new Student();
                            std = Create_object();
                            for (int i = 0; i < mycollection.list.Count; i++)
                            {
                                if (mycollection.Search(std))
                                    Console.WriteLine(" Found : " + mycollection.list[i].Name + " " + mycollection.list[i].Age + " " + mycollection.list[i].GenderMale + " " + mycollection.list[i].Section);
                                else Console.WriteLine(" Soory not found");
                            }

                            break ;
                        }
                        case 7:
                        {
                            if (mycollection != null)
                            {
                                Console.WriteLine(" List After copy");
                                foreach (Student student in mycollection.list)
                                    Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.GenderMale + " " + student.Section);
                            }
                            else
                                Console.WriteLine(" This collection is Empty....!");
                            Student[] stdarr = new Student[mycollection.list.Count];
                            mycollection.Copy(stdarr);
                            Console.WriteLine(" Array copy From list");
                            foreach(Student student in stdarr)
                                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.GenderMale + " " + student.Section);
                         // mycollection.Reset(); 
                            break;
                        }
                        case 8:
                        {
                            if(mycollection.index != 0)
                            foreach(Student student in mycollection.list)
                                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.GenderMale + " " + student.Section);
                           else
                                Console.WriteLine(" This collection is Empty....!");
                            break;
                        }
                        case 9:
                            break;
                        default:
                        {
                            Console.WriteLine(" Please try again");
                            Work();
                            break ;
                        }

                }
            }
        }
        public static Student Create_object()
        {

            //Student student = new Student();
            //Console.WriteLine(" Enter ID: ");
            //int id = 0; bool success = false;
            //do
            //{
            //    success = int.TryParse(Console.ReadLine(), out id);
            //    if (!success)
            //        Console.WriteLine(" Please try again");
            //    else
            //        student.Id = id;
            //} while (!success);
            //Console.WriteLine(" Enter Name: ");
            //student.Name = Console.ReadLine();
            //Console.WriteLine(" Enter Age");
            //int age = 0;
            //do
            //{
            //    success = int.TryParse(Console.ReadLine(), out age);
            //    if (!success)
            //        Console.WriteLine(" Please try again");
            //    else
            //        student.Age = age;
            //} while (!success);
            //Console.WriteLine(" Enter Gender");
            //string str = Console.ReadLine();
            //if (str == "female")
            //    student.GenderMale = false;
            //else if (str == "male")
            //    student.GenderMale = true;
            //Console.WriteLine(" Enter Section");
            //student.Section = Console.ReadLine();
            Student student = new Student() { Id = 101, Name = "Bisho" , Age = 27 , GenderMale = true , Section = "SW"};
            return student;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t Lab 12");
            Work();
            Console.ReadKey();  

        }
    }
}
