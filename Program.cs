// See https://aka.ms/new-console-template for more information
using System;



public class ratonalExpression
{
    public double[] constants{get;set;}
    public int degree
    {
        get{return constants.Length;}
    }

    

    public ratonalExpression(int entered)
    {
        constants = new double[entered];
    }


}
class program
{
    public static void Main()
    {

        //Console.WriteLine("hereh");
        ratonalExpression ghg = new ratonalExpression(4);

    Console.WriteLine(ghg.degree);
    }



};