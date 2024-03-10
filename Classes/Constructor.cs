using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpIntermediate;



    //**Topic is focused on constructors **
    public class Customer 
    {
        public string Name;

        // so what we get from the outside of the constructor (the brackets i.e constructor parameters , those parameters will appear be copied in the name field 
        // constructor name will apppear the same as the class 
        public Customer(string name ) {
        
        this.Name = name;
        }

    }




