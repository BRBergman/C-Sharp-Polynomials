// See https://aka.ms/new-console-template for more information
using System;

//to do: make a get amd set for each value
//maybe the number that the value is in the double is the exponant so constants[0] would be the just number
public class polynomial
{
    //ordered from back to front
    public double[] constants{get;set;}
    public int degree {get{return constants.Length;}}

    public polynomial(double[] entered)
    {
        constants = new double[entered.Length];
        entered.CopyTo(constants,0);
    }



}
class program
{
    static void Main()
    {
        polynomial ghg = new polynomial(new double[]{1,2,3});

        //Console.WriteLine(ghg.degree);
        ghg.constants.Append(4);
        Console.WriteLine(ghg.degree);
    }



};