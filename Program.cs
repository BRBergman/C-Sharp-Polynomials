// See https://aka.ms/new-console-template for more information
using System;

//to do: make a get amd set for each value
//maybe the number that the value is in the double is the exponant so constants[0] would be the just number
public class polynomial
{
    public double[] constants{get;set;}
    public int degree {get{return constants.Length;}}

    public polynomial(double[] entered)
    {
        constants = new double[entered.Length];
        entered.CopyTo(constants,0);
    }

    //doenst work just yet aaaaa
    public double evaluatewithx(double x)
    {
        double rerun = 0;
        for (int i = 0; degree > i; i++)
        {
            //Console.WriteLine(i);
            if (i!=0 )
            {
                rerun += (constants[i]* Math.Pow(x,i));
                Console.WriteLine("helb {0}",i);
            }
            else
            {
                Console.WriteLine("bleh");
                rerun += constants[i];
            }   
            Console.WriteLine(rerun);
        }
        return rerun;
    }


}
class program
{
    public static void Main()
    {
        polynomial ghg = new polynomial(new double[]{1,2,3});

        //Console.WriteLine(ghg.degree);
        Console.WriteLine(ghg.evaluatewithx(2));
    }



};