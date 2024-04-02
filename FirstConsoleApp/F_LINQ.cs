// LINQ -Language Integrated Query 
using System;
using System.Collections.Generic;
using System.Linq;

class LINQLearner
{
    void  Learn(){
        int[] numbers=[3,4,5,67, 12, 34, 56, 78, 89, 98,123];
        List<string> names =["anisha","rita","sapana", "anjana", "alex"];

        var s1= new Student ("bishnu", 12, new DateTime(1998,12,12));
        var s2= new Student ("ram", 12, new DateTime(1998,12,12));
        var s3= new Student ("syam ", 12, new DateTime(1998,12,12));
        var s4= new Student ("vishnu", 12, new DateTime(1998,12,12));
        var s5= new Student ("sita", 12, new DateTime(1998,12,12));

        List<Student> students =[s1,s2,s3,s4,s5];
        // Get odd numbers from "numbers"

    var oddNumbers = numbers.Where(number => number %2 ==1); //Lambda Expression

    // Get  squares of all items  in "numbers"
    var squares = numbers.Select(x=>x*x);

    // Get squares of even numbers only 
    // Method Syntax
    var evenSquares = numbers.Where(x =>x %2 ==0).Select(y=>y*y); //chaining of where and select

    // int  from;

    // Query Syntax
    evenSquares= from x in numbers where x%2 ==0 select x*x;

    // Get all names initials 
    var initials =names.Select(name=> name[0]); //['A','R','S', 'S','A']

    // Order names in ascending order
     var namesOrdered = names.OrderBy(x=>x);


// Find Students with name starting with "B"
var bStudents = students.Where(student=>student.name.ToLower().StartsWith('b'));

//  Group students by birth month
var dobGroups = students.GroupBy(student=>student.Dob.Month);

// Get youngest student
var youngest = students.OrderByDescending(x=>x.Dob).First();
youngest = students.MaxBy(x=>x.Dob);
// youngest = students.FirstOrDefault(x=>DateTime.Now - x.Dob)


    }
}