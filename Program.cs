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
    public double evaluatewithx(double x)
    {
        double rerun = 1;
        for (int i = degree-1; degree-1 < i; i--)
        {
            Console.WriteLine(i);
            if (i!=0 )
            {
                rerun += constants[i] * Math.Pow(x,i);

            }
            else
            {
                rerun += constants[i];
            }   
        }
        return rerun;
    }


}
class program
{
    public static void Main()
    {
        double[] f = {1f,3f,2f};
        polynomial ghg = new polynomial(f);

        //Console.WriteLine(ghg.degree);
        Console.WriteLine(ghg.evaluatewithx(1));
    }



};