using System;

namespace CodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Testing
            // Objectives
            // Why do we test?
            // What do we test?
            // => To write bug free code
            // => We write tests to have confidence in our code
            // => Ensure that our code behaves correctly under all circumstances

            // What is a project?
            // => Is a code base

            // What is a solution?
            // => Is a collection of projects

            // How do we write tests?
            // => We need to create a test project
            // => We need to add a reference via the dependencies
            // => Then we create a new class, add in the Microsoft.VisualStudio.TestTools.UnitTesting;
            // => Then add in our classes and methods

            // How can we write code that is more testable?
            // What are positive tests?
            // What are negative tests?
            // What are edge cases?
            // What is a test class?
            // What is a test method?
            // What is a test setup?
            // What is a test cleanup?

            // What is TDD?
            // Test Driven Design

            StringUtils.StringUtils.Reverse("Word");
        }
    }
}
