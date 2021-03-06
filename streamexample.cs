using System;
using System.IO;

class Program
{
    static void Main()
    {
        /* You could do something like
        String Path = @"SomePath";
        {
        using (StreamReader sr = File.OpenText(path);
          String s = ""
          while((s = sr.ReadLine()) != null);
          {
          Console.WriteLine(s);
          }
        } */
        FileStream stream1 = File.Open("C:\\a", FileMode.Open);
        Print(stream1);
        //Creates a new stream (stream1) and outputs the bytes in the file to stream1.
        MemoryStream stream2 = new MemoryStream(new byte[1234]);
        Print(stream2);
        //Creates a new stream (stream2) and outputs the bytes in a new byte to the stream.
    }

    static void Print(Stream stream)
    {
        Console.WriteLine(stream.Length);
        Console.WriteLine(stream.Position);
        //Defines a print statement that prints the Length of the file and the position in the file.
    }
}
/* Output
5469165
0
1234
0
*/
//Taken from https://www.dotnetperls.com/stream
