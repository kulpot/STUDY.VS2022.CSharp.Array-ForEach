using System;

//ref link:https://www.youtube.com/watch?v=LbAblJTInG0&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=11
//ctrl+k+u -- uncomment highlighted lines

static class MainClass
{   // extension method
    //static void ForEach(this int[] ints, Action<int> action)
    static void ForEach<T>(this T[] ints, Action<T> action)
    {
        //foreach (int i in ints)
        foreach (T i in ints)
            action(i);
    }
    static void Main()
    {

        //int[] ints = new int[] { 5, 2, 8, 9, 1, 0, 4 };
        double[] ints = new double[] { 5, 2, 8, 9.1234321, 1, 0, 4 };
        //Array.ForEach(ints, Console.WriteLine); // static build in foreach
        //ints.ForEach(Console.WriteLine);
        ints.ForEach(i => Console.Write(i + " "));    // lambda expression
        //foreach (int i in ints)
        //    Console.WriteLine(i);
    }
}