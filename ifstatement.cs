using System;

class Program
{
    static void Main()
    {
        int value = 10 / 2;
        if (value == 5) //If the value is 5 - DoSomething.
        {
            Console.WriteLine(true);
        } /*Potential improvement */
        else if(SomeOtherCondition)
        {
        /*DoSomethingElse(); Calls the DoSomethingElse() arbitrary method if the SomeOtherCondition arbitrary condition is met.
        won't execute if the first if condition is true.*/
        }
        
    }
}

//Taken from https://www.dotnetperls.com/if
