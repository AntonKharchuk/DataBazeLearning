
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBazeLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
