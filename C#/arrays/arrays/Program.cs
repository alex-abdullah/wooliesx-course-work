using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] myArray;

            int anInt;
            int[] anArrayOfInts; 
            myArray = new int[7];

            Console.WriteLine(myArray.Length);

            short myShort = 120;
            myArray[2] = myShort;
            long myLong = 3000000000000;

        
            Console.WriteLine(myArray[0]);

            string[] names = new string[] { "Alex", "Earn" };

            Console.WriteLine(names.Length);
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            Console.WriteLine(string.Join(", ", myArray));
            Console.WriteLine(string.Join(", ", names));

            //Console.Write(myArray[2].ToString());
            Console.WriteLine(names);


            // PROBLEM:
            // If we wanted to add an item to an array, how would we do it?

            string[] students = { "Esther", "Shailo", "Alex" };
            string NewStudent = "Geoff";
            string AnotherStudent = "Erin";

            // SOLUTION:
            // Create a new array that is one bigger than the previous one
            // HINT: use the previous array's length

            // Copy everything from the previous array into the new array
            // HINT: use a for loop

            // Add our new item at the last index of the array
            // HINT: use the array's .length

            // reassign our new array to the variable of the old array
            // HINT: you can just replace the old variable's value with the new one


            string[] MoreStudents = new string[5];
            for(int i = 0; i < students.Length; i++)
            {
                MoreStudents[i] = students[i];
            }

            MoreStudents[3] = NewStudent;
            MoreStudents[4] = AnotherStudent;

            Console.WriteLine(string.Join(", ", MoreStudents));

            students = MoreStudents;

            // Array Copy Method
            Array.Copy(students, MoreStudents, students.Length);
            Console.WriteLine(string.Join(", ", MoreStudents));


            // Instance array.CopyTo
            students.CopyTo(MoreStudents, 0);
            Console.WriteLine(string.Join(", ", MoreStudents));

            // When we use arrays, in JS we like to use iterators for things such as
            // incrementing every item in an array (map)
            // CHALLENGE: MAP
            // STEPS:
            // Create an array of 10+ integers:

            int[] MyScores = { 10, 5, 8, 18, 20, 40, 30, 21, 47, 56, 61 };


            // Create new array of same length:

            int[] NewScores = new int[MyScores.Length];

            //Create loop that iterates over first array:

            for (int i = 0; i < MyScores.Length; i++)
            {
                NewScores[i] = MyScores[i] + 5;
            }


            Console.WriteLine(string.Join(", ", NewScores));


            //Array.Reverse(NewScores);

            int[] MoreNewScores = new int[NewScores.Length];
            int k = 0;

            for (int i = NewScores.Length - 1; i >= 0;)
            {

                MoreNewScores[k++] = NewScores[i--];
            }

            Console.WriteLine(string.Join(", ", MoreNewScores));




            // reversing an array

            string[] myStringArray = { "I", "want", "to", "be", "backwards" };
            string[] NewString = new string[myStringArray.Length];
            int x = 0;

            for (int i = myStringArray.Length - 1; i >= 0;)
            {
                NewString[x++] = myStringArray[i];
            }

            Console.WriteLine(string.Join(" ", NewString));





        }
    }
}
