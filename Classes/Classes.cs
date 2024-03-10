using System;
using System.Collections.Generic;
using System;

namespace Classes
{
    // classes 
    public class Person

    {
        //fields **
        public string Name;

        // method **
        // declare which parameter that you want the person to introduce himself to 
        //parameters are optional depends if you have a declaration

        public void Introduce(string to)
        {
            // format string which are kind of like templates
            // can create  an object from this string 
            Console.WriteLine("Hi {0}, I am {1}", to, Name );

        }

        // Maybe you want to create a personal object from the above string , you have to create a Parse method 
        // can change to **public static person parse** , so you dnt have to create the var new person object and in replace of that statement in replace of 
        //- person obejct just put (var p = person.Parse(); - adding the parameter name in the brackets such as the name , basically the string 
        public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;


            return person;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // this is an object callled person object 
        var person = new Person();
        person.Name = "Lingelihle";
        person.Introduce("lINGELIHLE NYUSWA ");


        // we just delared a class and created a class with a field , method resulting in an object which is an instance of a class 

    }

 
}
