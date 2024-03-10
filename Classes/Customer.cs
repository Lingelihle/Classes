using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  
      public class Customer
    {
    public int Id;
    public string Name;
    public List<Order> Orders; // generic parameter representing a list of parameters , always send field to the next empty constructor

    public Customer()
    {

        // we put our order property here 
        Orders = new List<Order>();

    }

    // another example of a constuctor with a parameter , constructor parameters will be copied in its field 
    public Customer(int id)
        :this() // it will call the constuctor without a parameter
    
    {
         
        this.Id = id;
    }
    // you can add more than one parameter in a constructor , they will copied just the  same in the below field  
    public Customer(int id, string name)
        :this(id) // it will use a constructor that first calls the id parameter 
    {
        this.Id = id; // do this is not necessary if the ** this keyword is present**
        this.Name = name;
        
    }





    static void Main(string[] args)
    {
       // THIS LINE WILL TURN RED IF THE PROGRAM CANT FIND A DEFAULT CONSTRUCTOR(CONSTRUCTOR WITH NO PARAMETERS) WITHIN THE PROGRAM 
        var customer = new Customer();

        customer.Id = 1;
        customer.Name = "Lingelihele";

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);

       
    }

}

