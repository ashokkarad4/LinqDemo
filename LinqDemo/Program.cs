﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Course> coures = new List<Course>() {
                new Course{Id=101,Name="C#",Fees=2000 },
                  new Course{Id=102,Name="MVC", Fees=4000 },
                  new Course{Id=103,Name="SQL",Fees=6000 },
                  new Course{Id=104,Name="Core Java",Fees=8000 },
                  new Course{Id=105,Name="Ad Java",Fees=10000 },
            };

            var result1=from c in coures
                        select c;

            var result2 = from course in coures
                          where course.Fees < 8000
                          orderby course.Name descending
                          select course;

            var result3 = from c in coures
                          where c.Name.EndsWith('a')
                          select c;

            //using LABDA expression
            // =>  arrow operator  also called lambda expression
            var result4 = coures.Where(x => x.Fees < 8000).OrderByDescending(y => y.Name).ToList();

            var result5 = coures.Where(x => x.Id == 101).FirstOrDefault();

            var result6 = coures.Where(x => x.Fees > 5000).OrderByDescending(y => y.Name).ToList();
            foreach (Course c in result6)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }
            Console.WriteLine("//////////////");
            foreach (Course c in result2)
            {
                Console.WriteLine($"{c.Id}  {c.Name} {c.Fees}");
            }

        }
    }
}
