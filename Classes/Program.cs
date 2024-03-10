// Declaring clasess they must contain a field and a method 
// method determines the action of the class while the field is like the attribute or just a member of a class 

// Declaren classes 

public class Person
{

    // This is a field 
    public string Name;

    //Accesas Modifier with a signature of a method ( basically this a method)
    // public void mean it does not return any value, 
    // it has an identifier and in those brackets we can put parameter that method may need 
    public void Introduce()


    {

        // this a code inside a method 

        Console.WriteLine("Hi my name is " + Name);
    }

    internal void Introduce(string v)
    {
        throw new NotImplementedException();
    }
}



// Creating Objects 