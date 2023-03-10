// See https://aka.ms/new-console-template for more information
using System;



public class polynomial
{
    public double[] constants{get;set;}
    public int degree {get{return constants.Length;}}

    

    public polynomial(int entered)
    {
        constants = new double[entered];
    }


}
class program
{
    public static void Main()
    {

        //Console.WriteLine("hereh");
        polynomial ghg = new polynomial(4);

    Console.WriteLine(ghg.degree);
    }



};