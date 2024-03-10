using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //** ALL ABOUT METHODS
    public class Point // you have  A class named point 
    {

        public void Move(int x, int y) { } // this a method called Move, its a method with signatures 
    }
}
public class Calculator
{
    public int Add(int[] numbers)  // this helps with method overload, arrary in parameters makes you declare it only once 
    {
        var result = Calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, });
    }
}
//** The Params modifier 
public class Calculator
{
    public int Add(params int[] numbers)  // this helps with method overload, arrary in parameters makes you declare it only once 
    {
        var result = Calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, });
        var result = Calculator.Add(1, 2, 3, 4, 5, 6, 7); 
    }
}