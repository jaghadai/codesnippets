public delegate string SomeDelegate(int someArg);

public delegate void Action<TArg1>(TArg1 arg1);
public delegate TReturn Func<TReturn, TArg1>(TArg1 arg1);
public delegate TReturn Func<TReturn, TArg1, TArg2>(TArg1 arg1, TArg2 arg2);

public class Foo
{
    public event Action<int> MyEvent; //Registers the desired signature of the methods that subscribe to the event.
}

public class Program
{
    private static Logger logger;

    public static void Main()
    {
        var foo = new Foo();
        //Adds delegates to the event (which are just methods that are subscribing to the event)
        foo.MyEvent += new Action<int>(LogHandler);
        foo.MyEvent += delegate(LogHandler);
        foo.MyEvent += LogHandler; //C# can detect the type of LogHandler at runtime to see if it matches the event.
        foo.MyEvent += someArg => logger.Log(someArg); //logger.Log must be some extant function.
        //Registering the logger eventhandler for foo.
    }
    
    private static void LogHandler(int someArg)
    {
        logger.Log(someArg);
    }
}

//Taken from - David Klock (Skype Session)
//David wrote this out as an example of how delegates and eventhandling worked in C#.
//As a part of a tutoring session.
