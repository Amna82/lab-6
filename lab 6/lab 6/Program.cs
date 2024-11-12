using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Activity1();
            Activity2();
            Activity3();
            Activity4();
        }


        static void Activity1()
        {
            List<int> numbers = new List<int>();
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(0);
            Console.WriteLine("Original list.");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            Console.WriteLine("Sorted list.");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Remove(4);
            Console.WriteLine("After removing 6.");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

                static void Activity2()
            {
                 Dictionary<string, string> countries = new Dictionary<string, string>();
             countries["USA"] = "Washington DC";
             countries["France"] = "Paris";
             countries["Japan"] = " Tokyo";
             countries["India"] = " Delhi";
             Console.WriteLine("Countries and capitals");
             foreach(var pair in countries)
             {
                 Console.WriteLine($"{ pair.Key} : { pair.Value}");
             }
             Console.WriteLine($"\n capital of japan: {countries["Japan"]}");
             countries.Remove("France");
             Console.WriteLine("Countries after removing france");
             foreach (var pair in countries)
             {
                 Console.WriteLine($"{pair.Key} : {pair.Value}");
             }
            }

            static void Activity3()
            {
                    ArrayList arraylist = new ArrayList();
                 arraylist.Add(10);   
                 arraylist.Add("HELLO");
                 arraylist.Add(30.5);
                 arraylist.Add("WORLD");
                Console.WriteLine("Arrayist items"); 
                 foreach(var item in arraylist)
                 {
                     Console.WriteLine(item);    
                 }
                 arraylist.Remove("HELLO");
                 Console.WriteLine("Remove elements in arraylist");
                 foreach (var item in arraylist)
                 {
                     Console.WriteLine(item);
                 }
            }

            static void Activity4()
            {
                    Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
                    students["Alice"] = new List<int> { 85, 88, 89 };
                    students["Bob"] = new List<int> { 70, 60, 75 };
                    students["Charlie"] = new List<int> { 95, 93, 94 };
                    students["Daisy"] = new List<int> { 55, 60, 58 };
                    Console.WriteLine("students average");
                    foreach (var student in students)
                    {
                        double average = student.Value.Average();
                        Console.WriteLine($"{student.Key}: {average:F2}");
                    }
                    var topStudent = students.OrderByDescending(a => a.Value.Average()).First();
                    var lowStudent = students.OrderBy(a => a.Value.Average()).First();

                    Console.WriteLine($"Top performing student is: {topStudent.Key} ");
                    Console.WriteLine($"worst performing student is : {lowStudent.Key} ");
                    var failingStudent = students.Where(a => a.Value.Average() < 60).Select(a => a.Key).ToList();
                    foreach (var student in failingStudent)
                    {
                        students.Remove(student);
                    }
                    Console.WriteLine("After removing low performing");
                    foreach (var student in students)
                    {
                        double average = student.Value.Average();
                        Console.WriteLine($"{student.Key}: {average:F2}");
                    }
                }
            }
        }
        
